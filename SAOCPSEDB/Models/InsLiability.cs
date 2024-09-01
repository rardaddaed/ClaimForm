using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsLiability
{
    public int Insurerloadid { get; set; }

    public int Insliabilityno { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public string? Liabilitystatuscodetype { get; set; }

    public string? Liabilitystatus { get; set; }

    public DateTime? Liabilitystatusfromdate { get; set; }

    public DateTime? Liabilitystatustodate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsInsurerload Insurerload { get; set; } = null!;
}
