using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerSascheduledescriptionSa
{
    public int Sascheduleid { get; set; }

    public int Sascheduledescriptionid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public string? Description { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SerSascheduleSa Saschedule { get; set; } = null!;
}
