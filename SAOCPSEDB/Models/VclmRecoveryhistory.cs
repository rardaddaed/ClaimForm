using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmRecoveryhistory
{
    public int Claimid { get; set; }

    public int? Recoveryestimateno { get; set; }

    public int? Recoveryid { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public string? Recoveryestimatecategory { get; set; }

    public decimal? Recoveryvariation { get; set; }

    public decimal? Estimatedrecoveryvariation { get; set; }

    public decimal? Totalrecovered { get; set; }

    public decimal? Totalestimatedrecovery { get; set; }

    public int? Changedbyuserid { get; set; }

    public string? Reason { get; set; }
}
