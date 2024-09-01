using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class BaseOpenclaim
{
    public int Claimid { get; set; }

    public string? Claimnumber { get; set; }

    public int? Jurisdictionzone { get; set; }

    public string? Claimtype { get; set; }

    public string? Claimclassification { get; set; }

    public DateTime? Dateentered { get; set; }

    public string? Statuscodetype { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Datestatuschanged { get; set; }
}
