using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsFilenotestaging
{
    public int Stagingloadid { get; set; }

    public int Filenotestagingno { get; set; }

    public int? Rownumber { get; set; }

    public string? Rawdata { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public string? Subject { get; set; }

    public string? Note { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsStagingload Stagingload { get; set; } = null!;
}
