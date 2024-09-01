using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRehab
{
    public int Claimid { get; set; }

    public int Rehabno { get; set; }

    public int? Rehabid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual RehRehab? Rehab { get; set; }
}
