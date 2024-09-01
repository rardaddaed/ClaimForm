using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRecovery
{
    public int Claimid { get; set; }

    public int Recoveryno { get; set; }

    public int? Recoveryid { get; set; }

    public DateTime? Submissiondate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual RecRecovery? Recovery { get; set; }
}
