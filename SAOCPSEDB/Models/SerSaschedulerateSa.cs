using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerSaschedulerateSa
{
    public int Sascheduleid { get; set; }

    public int Saschedulerateid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public decimal? Amount { get; set; }

    public int? Servicerateid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SerSascheduleSa Saschedule { get; set; } = null!;

    public virtual SerRate? Servicerate { get; set; }
}
