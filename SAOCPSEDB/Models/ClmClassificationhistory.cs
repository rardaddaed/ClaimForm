using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmClassificationhistory
{
    public int Claimid { get; set; }

    public int Classificationhistoryno { get; set; }

    public DateTime? Datechanged { get; set; }

    public string? Classification { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
