using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmSurgerySa
{
    public int Claimid { get; set; }

    public int Sasurgeryno { get; set; }

    public DateTime? Surgerydate { get; set; }

    public short? Injuryrelated { get; set; }

    public string? Comments { get; set; }

    public DateTime? Estimatedfitdate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
