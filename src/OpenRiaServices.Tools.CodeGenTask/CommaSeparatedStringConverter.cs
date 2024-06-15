using System;
using System.ComponentModel;
using System.Globalization;

namespace OpenRiaServices.Tools.CodeGenTask;
#nullable enable

internal sealed class CommaSeparatedStringConverter : TypeConverter
{
    public override object ConvertFrom(ITypeDescriptorContext? context, CultureInfo? culture, object value)
    {
        if (value is string stringValue)
        {
            return stringValue.Split(',');
        }

        throw new NotSupportedException("Can't convert value to verbosity.");
    }
}
