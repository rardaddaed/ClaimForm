using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class BaseClmRecoverysummary
{
    public int Claimid { get; set; }

    public string Recoveryestimatecategory { get; set; } = null!;

    public string? Recoveryestimatecatdisplay { get; set; }

    public decimal? Totalrecovered { get; set; }

    public decimal? Pendingrecoveries { get; set; }

    public decimal? Outstandingrecoveries { get; set; }

    public decimal? Totalrecoveryestimate { get; set; }
}
