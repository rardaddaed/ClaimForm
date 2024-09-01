using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmFilenote
{
    public int Claimid { get; set; }

    public int Filenoteno { get; set; }

    public int? Filenoteid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual FnFilenote? Filenote { get; set; }
}
