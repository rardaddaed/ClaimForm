using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsWorkcapacitystaging
{
    public int Stagingloadid { get; set; }

    public int Workcapacitystagingno { get; set; }

    public int? Rownumber { get; set; }

    public string? Rawdata { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public DateTime? Originaldecisiondate { get; set; }

    public string? Decisiontypecodetype { get; set; }

    public string? Decisiontype { get; set; }

    public string? Reviewstagecodetype { get; set; }

    public string? Reviewstage { get; set; }

    public string? Datetypecodetype { get; set; }

    public string? Datetype { get; set; }

    public DateTime? Transactiondate { get; set; }

    public string? Outcomecodetype { get; set; }

    public string? Outcome { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsStagingload Stagingload { get; set; } = null!;
}
