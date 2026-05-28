#!/usr/bin/env python3

import argparse
import subprocess
from pathlib import Path


def discover_projects(repo_root: Path) -> list[Path]:
    project_paths = set()
    for unshipped in repo_root.rglob("PublicAPI.Unshipped*.txt"):
        for candidate in unshipped.parent.glob("*.csproj"):
            project_paths.add(candidate)
    return sorted(project_paths)


def run_dotnet_format(projects: list[Path]) -> None:
    for project in projects:
        cmd = [
            "dotnet",
            "format",
            str(project),
            "analyzers",
            "--diagnostics",
            "RS0016",
            "--severity",
            "warn",
        ]
        print(f"Running: {' '.join(cmd)}")
        subprocess.run(cmd, check=True)


def parse_api_file(path: Path) -> tuple[list[str], list[str]]:
    lines = path.read_text(encoding="utf-8-sig").splitlines()
    directives = []
    entries = []
    for line in lines:
        stripped = line.strip()
        if not stripped:
            continue
        if stripped.startswith("#"):
            directives.append(stripped)
        else:
            entries.append(stripped)
    return directives, entries


def unique_in_order(values: list[str]) -> list[str]:
    seen = set()
    result = []
    for value in values:
        if value in seen:
            continue
        seen.add(value)
        result.append(value)
    return result


def write_api_file(path: Path, directives: list[str], entries: list[str]) -> None:
    output = []
    if directives:
        output.extend(unique_in_order(directives))
    if entries:
        if output:
            output.append("")
        output.extend(sorted(unique_in_order(entries), key=str.casefold))
    text = "\n".join(output)
    if text:
        text += "\n"
    path.write_text(text, encoding="utf-8-sig")


def promote_unshipped(repo_root: Path) -> None:
    for unshipped in sorted(repo_root.rglob("PublicAPI.Unshipped*.txt")):
        shipped = unshipped.with_name(unshipped.name.replace("Unshipped", "Shipped", 1))
        if not shipped.exists():
            continue

        unshipped_directives, unshipped_entries = parse_api_file(unshipped)
        to_ship = [entry for entry in unshipped_entries if not entry.startswith("*REMOVED*")]
        kept_unshipped = [entry for entry in unshipped_entries if entry.startswith("*REMOVED*")]

        if not to_ship:
            continue

        shipped_directives, shipped_entries = parse_api_file(shipped)
        combined_directives = unique_in_order(shipped_directives + unshipped_directives)
        write_api_file(shipped, combined_directives, shipped_entries + to_ship)
        write_api_file(unshipped, unshipped_directives, kept_unshipped)
        print(f"Promoted {len(to_ship)} entries: {unshipped} -> {shipped}")


def main() -> None:
    parser = argparse.ArgumentParser(
        description="Sync PublicAPI.Unshipped.txt files and/or promote unshipped entries into shipped API files."
    )
    parser.add_argument("--repo-root", type=Path, default=Path(__file__).resolve().parents[1])
    parser.add_argument("--sync-unshipped", action="store_true", help="Run dotnet format analyzers (RS0016).")
    parser.add_argument("--ship", action="store_true", help="Move non-removed entries from unshipped files to shipped files.")
    args = parser.parse_args()

    if not args.sync_unshipped and not args.ship:
        args.sync_unshipped = True
        args.ship = True

    repo_root = args.repo_root.resolve()
    projects = discover_projects(repo_root)

    if args.sync_unshipped:
        run_dotnet_format(projects)
    if args.ship:
        promote_unshipped(repo_root)


if __name__ == "__main__":
    main()
