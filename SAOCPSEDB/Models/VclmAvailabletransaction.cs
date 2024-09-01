using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmAvailabletransaction
{
    public int Claimid { get; set; }

    public int? Transactionid { get; set; }

    public string? Referencenumber { get; set; }

    public int? Partyid { get; set; }

    public int? Accountid { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public decimal? Totalamount { get; set; }

    public decimal? Matchedamount { get; set; }
}
