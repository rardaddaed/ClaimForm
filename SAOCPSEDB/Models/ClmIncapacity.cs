using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmIncapacity
{
    public int Claimid { get; set; }

    public int Incapacityno { get; set; }

    public DateTime? Dateceased { get; set; }

    public DateTime? Timeceased { get; set; }

    public DateTime? Dateestimatedfit { get; set; }

    public DateTime? Datefit { get; set; }

    public DateTime? Datereturn { get; set; }

    public DateTime? Timereturn { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
