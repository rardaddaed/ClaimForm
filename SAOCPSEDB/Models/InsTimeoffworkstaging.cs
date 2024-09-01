using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsTimeoffworkstaging
{
    public int Stagingloadid { get; set; }

    public int Timeoffworkstagingno { get; set; }

    public int? Rownumber { get; set; }

    public string? Rawdata { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public DateTime? Dateceasedwork { get; set; }

    public DateTime? Timeceasedwork { get; set; }

    public DateTime? Estimatedreturndate { get; set; }

    public DateTime? Returndate { get; set; }

    public DateTime? Returntime { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsStagingload Stagingload { get; set; } = null!;
}
