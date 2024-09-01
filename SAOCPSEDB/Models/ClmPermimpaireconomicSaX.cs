using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPermimpaireconomicSaX
{
    public int Claimid { get; set; }

    public int Sapermimpairno { get; set; }

    public int? NonPrescribedsum { get; set; }

    public int? NonDeductionscost { get; set; }

    public int? NonDeductionspercent { get; set; }

    public int? NonDeductionsentitlementamount { get; set; }

    public decimal? Compamount { get; set; }

    public int? Deductionscost { get; set; }

    public int? Deductionspercent { get; set; }

    public int? Deductionsentitlementamount { get; set; }

    public int? Prescribedsum { get; set; }

    public int? Agefactor { get; set; }

    public decimal? Hoursworkedfactor { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmPermimpairSa ClmPermimpairSa { get; set; } = null!;
}
