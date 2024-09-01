using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmOtherinjurysummary
{
    public int Claimid { get; set; }

    public int? Sufferedsimilarinjury { get; set; }

    public int? Compensationclaimmade { get; set; }

    public string? Details { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
