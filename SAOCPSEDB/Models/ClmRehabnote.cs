using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRehabnote
{
    public int Claimid { get; set; }

    public int Rehabnoteno { get; set; }

    public int? Filenoteid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual FnFilenote? Filenote { get; set; }
}
