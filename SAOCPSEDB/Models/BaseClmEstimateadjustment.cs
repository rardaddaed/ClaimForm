using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class BaseClmEstimateadjustment
{
    public int Claimid { get; set; }

    public int? Estimateno { get; set; }

    public int? Paymentid { get; set; }

    public int? Itemno { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public string? Estimatecategory { get; set; }

    public decimal Paiditemtotal { get; set; }

    public decimal? Incurredamount { get; set; }

    public string? Reason { get; set; }

    public int? Changedbyuserid { get; set; }
}
