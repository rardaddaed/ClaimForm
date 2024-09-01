using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRehabstatus
{
    public int Claimid { get; set; }

    public string? Rehabstatuscodetype { get; set; }

    public string? Rehabstatus { get; set; }

    public DateTime? Rehabstatusdate { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Daterehabstatuschanged { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
