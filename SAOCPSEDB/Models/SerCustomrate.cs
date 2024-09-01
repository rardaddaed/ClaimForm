using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerCustomrate
{
    public int Customserviceid { get; set; }

    public int Customservicerateid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public decimal? Amount { get; set; }

    public int? Servicerateid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SerCustom Customservice { get; set; } = null!;

    public virtual SerRate? Servicerate { get; set; }
}
