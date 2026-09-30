using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Nerdbank.MessagePack;
using PolyType;

namespace Cities
{


    /// <summary>
    /// These types are simple data types that can be used to build
    /// mocks and simple data stores.
    /// </summary>
    /// <remarks>
    /// These types have no static dependencies on Silverlight, but they
    /// are declared as 'partial' types so they may be extended after inclusion
    /// into other compilation units.
    /// </remarks>
    public partial class State
    {
        private readonly List<County> _counties = new List<County>();

        public string Name { get; set; }
        public string FullName { get; set; }
        public TimeZone TimeZone { get; set; }
        public ShippingZone ShippingZone { get; set; }
        public List<County> Counties { get { return this._counties; } }
    }

    public partial class County
    {
        public County() {
            Cities = new List<City>();
        }

        public string Name { get; set; }
        public string StateName { get; set; }
        public State State {get;set;}

        public List<City> Cities { get; set; }
    }

    [KnownType(typeof(CityWithEditHistory))]
    [KnownType(typeof(CityWithInfo))]
    [DerivedTypeShape(typeof(CityWithEditHistory))]
    [DerivedTypeShape(typeof(CityWithInfo))]
    [TypeShape(Kind = TypeShapeKind.Object)]
    public partial class City
    {
        public City() {
            ZipCodes = new List<Zip>();
        }

        [PropertyShape(Name = "CityName")]
        [Key(0)]
        public string Name { get; set; }

        [Key(1)]
        public string CountyName { get; set; }

        [Key(2)]
        public string StateName { get; set; }

        [Key(3)]
        public County County {get;set;}
#if NET
#nullable enable
        [Key(4)]
        public string? ZoneName { get; set; }
#nullable restore
#else
        [Key(4)]
        public string ZoneName { get; set; }
#endif

        [Key(5)]
        public string CalculatedCounty { get { return this.CountyName; } set { } }

        [Key(6)]
        public int ZoneID { get; set; }

        [Key(7)]
        public List<Zip> ZipCodes { get;set; }

        public override string ToString()
        {
            return this.GetType().Name + " Name=" + this.Name + ", State=" + this.StateName + ", County=" + this.CountyName;
        }

        [PropertyShape(Ignore = true)]
        public int this[int index]
        {
            get
            {
                return index;
            }
            set
            {
            }
        }
    }

    // This class introduces an abstract derived class in the
    // City hierarchy that allows CUD and Custom methods to
    // record when they executed.  We do not update the history
    // with normal property sets, only with explicit domain
    // operations.
    public abstract partial class CityWithEditHistory : City
    {
        private string _editHistory;

        public CityWithEditHistory()
        {
            this.EditHistory = "new";
        }

        // Edit history always appends, never overwrites
        [Key(9)]
        public string EditHistory
        {
            get
            {
                return this._editHistory;
            }
            set
            {
                this._editHistory = this._editHistory == null ? value : (this._editHistory + "," + value);
                this.LastUpdated = DateTime.Now;
            }
        }

        [Key(10)]
        public DateTime LastUpdated
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString() + ", History=" + this.EditHistory + ", Updated=" + this.LastUpdated;
        }

    }

    public partial class CityWithInfo : CityWithEditHistory
    {
        public CityWithInfo()
        {
            ZipCodesWithInfo = new List<ZipWithInfo>();
        }

        [Key(11)]
        public string Info
        {
            get;
            set;
        }

        [Key(12)]
        public List<ZipWithInfo> ZipCodesWithInfo { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", Info=" + this.Info;
        }

    }

    [KnownType(typeof(ZipWithInfo))]
    public partial class Zip
    {
        public int Code { get; set; }
        public int FourDigit { get; set; }
        public string CityName { get; set; }
        public string CountyName { get; set; }
        public string StateName { get; set; }

        public City City {get;set;}
    }

    public partial class ZipWithInfo : Zip
    {
        public string Info
        {
            get;
            set;
        }
    }
}
