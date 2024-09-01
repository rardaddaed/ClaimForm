using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmRtwstatushistory
{
    public int Claimid { get; set; }

    public int? Rtwstatusno { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }
}
