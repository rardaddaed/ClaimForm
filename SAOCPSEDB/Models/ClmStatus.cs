using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmStatus
{
    public int Claimid { get; set; }

    public string? Statuscodetype { get; set; }

    public string? Status { get; set; }

    public string? Reasoncodetype { get; set; }

    public string? Reason { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Datestatuschanged { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
