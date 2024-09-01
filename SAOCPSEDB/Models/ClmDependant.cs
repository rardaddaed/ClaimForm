using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmDependant
{
    public int Claimid { get; set; }

    public int Dependantno { get; set; }

    public string? Relationship { get; set; }

    public int? Partialdependant { get; set; }

    public int? Partyid { get; set; }

    public int? Partylocationno { get; set; }

    public int? Partycontactno { get; set; }

    public string? Status { get; set; }

    public string? Joinedby { get; set; }

    public string? Reasonjoined { get; set; }

    public int? Undertakingfulltimeeducation { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ParContact? ParContact { get; set; }

    public virtual ParLocation? ParLocation { get; set; }

    public virtual ParParty? Party { get; set; }
}
