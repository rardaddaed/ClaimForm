using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsStatusstaging
{
    public int Stagingloadid { get; set; }

    public int Statusstagingno { get; set; }

    public int? Rownumber { get; set; }

    public string? Rawdata { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public string? Claimstatuscodetype { get; set; }

    public string? Claimstatus { get; set; }

    public DateTime? Statusfromdate { get; set; }

    public DateTime? Statustodate { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsStagingload Stagingload { get; set; } = null!;
}
