using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerCustomdescription
{
    public int Customserviceid { get; set; }

    public int Customservicedescriptionid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public string? Description { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SerCustom Customservice { get; set; } = null!;
}
