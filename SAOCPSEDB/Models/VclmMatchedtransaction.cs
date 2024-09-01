using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmMatchedtransaction
{
    public int Claimid { get; set; }

    public int Paymentid { get; set; }

    public int? Transactionid { get; set; }

    public int? Accountid { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public decimal? Matchedamount { get; set; }
}
