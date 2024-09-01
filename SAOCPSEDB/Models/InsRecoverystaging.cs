using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsRecoverystaging
{
    public int Stagingloadid { get; set; }

    public int Recoverystagingno { get; set; }

    public int? Rownumber { get; set; }

    public string? Rawdata { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public DateTime? Recoverydate { get; set; }

    public string? Recoverytypecodetype { get; set; }

    public string? Recoverytype { get; set; }

    public decimal? Recoveryamount { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsStagingload Stagingload { get; set; } = null!;
}
