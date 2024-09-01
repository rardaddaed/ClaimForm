using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmProvider
{
    public int Claimid { get; set; }

    public int Providerno { get; set; }

    public int? Providerpartyid { get; set; }

    public int? Providerlocationno { get; set; }

    public int? Providercontactno { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ParContact? ParContact { get; set; }

    public virtual ParLocation? ParLocation { get; set; }

    public virtual ParParty? Providerparty { get; set; }
}
