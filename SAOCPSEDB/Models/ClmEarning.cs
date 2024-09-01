using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmEarning
{
    public int Claimid { get; set; }

    public int Earningsno { get; set; }

    public int? Enteredbyuserid { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Dateeffective { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ClmEarningsSa? ClmEarningsSa { get; set; }

    public virtual SecUser? Enteredbyuser { get; set; }
}
