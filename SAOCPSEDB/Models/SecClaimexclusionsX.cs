using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecClaimexclusionsX
{
    public int Userid { get; set; }

    public int Inclusionno { get; set; }

    public int? Claimid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1? Claim { get; set; }

    public virtual SecUser User { get; set; } = null!;
}
