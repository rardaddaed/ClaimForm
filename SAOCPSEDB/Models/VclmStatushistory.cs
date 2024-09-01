using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmStatushistory
{
    public int Claimid { get; set; }

    public int? Statusno { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }
}
