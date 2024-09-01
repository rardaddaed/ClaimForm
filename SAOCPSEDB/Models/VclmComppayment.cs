using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmComppayment
{
    public int Claimid { get; set; }

    public int Paymentno { get; set; }

    public DateTime? Compensationfromdate { get; set; }

    public DateTime? Compensationtodate { get; set; }

    public DateTime? Dateauthorised { get; set; }

    public decimal? Comppay { get; set; }
}
