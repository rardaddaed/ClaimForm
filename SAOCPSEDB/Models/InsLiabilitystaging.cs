using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsLiabilitystaging
{
    public int Stagingloadid { get; set; }

    public int Liabilitystagingno { get; set; }

    public int? Rownumber { get; set; }

    public string? Rawdata { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public string? Liabilitystatuscodetype { get; set; }

    public string? Liabilitystatus { get; set; }

    public DateTime? Liabilitystatusfromdate { get; set; }

    public DateTime? Liabilitystatustodate { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsStagingload Stagingload { get; set; } = null!;
}
