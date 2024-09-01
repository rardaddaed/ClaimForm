using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRtwstatushistory
{
    public int Claimid { get; set; }

    public int Rtwstatusno { get; set; }

    public DateTime? Datertwstatuschanged { get; set; }

    public string? Rtwstatuscodetype { get; set; }

    public string? Rtwstatus { get; set; }

    public DateTime? Rtwstatusdate { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
