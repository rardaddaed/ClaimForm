using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class UtilClaimcount
{
    public int Claimid { get; set; }

    public int? Currentcount { get; set; }

    public int? Totalcount { get; set; }
}
