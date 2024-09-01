using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmCorrespondenceout
{
    public int Claimid { get; set; }

    public int Correspondenceoutno { get; set; }

    public int? Correspondenceoutid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual CorCorrespondenceout? Correspondenceout { get; set; }
}
