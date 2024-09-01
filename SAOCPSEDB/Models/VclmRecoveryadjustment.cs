using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmRecoveryadjustment
{
    public int Claimid { get; set; }

    public int? Recoveryestimateno { get; set; }

    public int? Recoveryid { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public string? Recoveryestimatecategory { get; set; }

    public decimal? Recoveredamount { get; set; }

    public decimal? Estimatedrecoveryamount { get; set; }

    public string? Reason { get; set; }

    public int? Changedbyuserid { get; set; }
}
