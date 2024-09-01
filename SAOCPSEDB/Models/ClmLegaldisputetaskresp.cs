using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmLegaldisputetaskresp
{
    public int Claimid { get; set; }

    public int Legalno { get; set; }

    public int Taskno { get; set; }

    public int Responsibilityno { get; set; }

    public string? Responsibilitytype { get; set; }

    public int? Responsibilityofuserid { get; set; }

    public string? Responsibilityofotheremail { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmLegaldisputetask ClmLegaldisputetask { get; set; } = null!;

    public virtual SecUser? Responsibilityofuser { get; set; }
}
