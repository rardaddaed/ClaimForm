using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmLegalentity
{
    public int Claimid { get; set; }

    public int? Legalentityid { get; set; }

    public int? Policyid { get; set; }

    public int? Coverageno { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual LegLegalentity? Legalentity { get; set; }

    public virtual PolCoverage? PolCoverage { get; set; }
}
