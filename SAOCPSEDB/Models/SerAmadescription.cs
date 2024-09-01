using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerAmadescription
{
    public int Amaserviceid { get; set; }

    public int Amadescriptionid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public string? Description { get; set; }

    public string? Other { get; set; }

    public int? Bv { get; set; }

    public string? Mod { get; set; }

    public string? Tim { get; set; }

    public string? Mbs1number { get; set; }

    public string? Mbs2number { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SerAma Amaservice { get; set; } = null!;
}
