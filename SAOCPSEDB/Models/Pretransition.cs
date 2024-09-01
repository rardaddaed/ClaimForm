using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Pretransition
{
    public int? Claimid { get; set; }

    public int? Transitioned { get; set; }

    public DateOnly? Transitiondesignateddate { get; set; }

    public DateOnly? Datetransitioned { get; set; }

    public string? Transitioncategory { get; set; }

    public string? Claimnumber { get; set; }

    public string? CurrentStatus { get; set; }
}
