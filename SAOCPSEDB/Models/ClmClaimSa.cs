using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmClaimSa
{
    public int Claimid { get; set; }

    public string? Workcoverclaimnumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public int? Tail { get; set; }

    public int? Reportableid { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual SubReportable? Reportable { get; set; }
}
