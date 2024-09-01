using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerAmarate
{
    public int Amaserviceid { get; set; }

    public int Amarateid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Mbs1rate { get; set; }

    public decimal? Mbs2rate { get; set; }

    public int? Servicerateid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SerAma Amaservice { get; set; } = null!;

    public virtual SerRate? Servicerate { get; set; }
}
