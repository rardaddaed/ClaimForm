using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RehSdrosterX
{
    public int Rehabid { get; set; }

    public int Sdrosterno { get; set; }

    public int? Weeknumber { get; set; }

    public DateTime? Datefrom { get; set; }

    public DateTime? Dateto { get; set; }

    public decimal? Hours { get; set; }

    public int? Days { get; set; }

    public string? Workactivities { get; set; }

    public string? Restrictions { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual RehRehab Rehab { get; set; } = null!;
}
