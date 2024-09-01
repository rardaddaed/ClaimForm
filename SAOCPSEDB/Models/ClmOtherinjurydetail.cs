using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmOtherinjurydetail
{
    public int Claimid { get; set; }

    public int Otherinjurydetailno { get; set; }

    public string? Employername { get; set; }

    public DateTime? Injurydate { get; set; }

    public string? Injurynature { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
