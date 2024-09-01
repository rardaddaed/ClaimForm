using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class BaseClmEstimatesummary
{
    public int Claimid { get; set; }

    public string Estimatecategory { get; set; } = null!;

    public string? Estimatecategorydisplay { get; set; }

    public decimal Paidamount { get; set; }

    public decimal Pendingpaidamount { get; set; }

    public decimal? Outstanding { get; set; }

    public decimal Incurredamount { get; set; }
}
