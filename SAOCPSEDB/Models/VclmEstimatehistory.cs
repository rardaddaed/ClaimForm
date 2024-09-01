using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmEstimatehistory
{
    public int Claimid { get; set; }

    public int? Estimateno { get; set; }

    public int? Paymentid { get; set; }

    public int? Itemno { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public string? Estimatecategory { get; set; }

    public decimal Paymentvariation { get; set; }

    public decimal? Incurredvariation { get; set; }

    public decimal? Totalpaid { get; set; }

    public decimal? Totalincurred { get; set; }

    public int? Changedbyuserid { get; set; }

    public string? Reason { get; set; }
}
