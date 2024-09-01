using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmPaymentitem
{
    public int Claimid { get; set; }

    public int Paymentid { get; set; }

    public int Itemno { get; set; }

    public string? Paymentcategorycodevalue { get; set; }

    public string? Paymenttypecodevalue { get; set; }

    public string? Itemstatuscodevalue { get; set; }

    public string? Estimatecategorycodevalue { get; set; }

    public int? Accountid { get; set; }

    public int? Serviceproviderpartyid { get; set; }

    public string? Supplierreference { get; set; }

    public DateTime? Servicedate { get; set; }

    public string? Itemnumber { get; set; }

    public string? Itemdescription { get; set; }

    public decimal? Scheduledamount { get; set; }

    public int? Quantity { get; set; }

    public decimal? Surcharge { get; set; }

    public decimal? Itemamount { get; set; }

    public decimal? Itemgst { get; set; }

    public decimal? Itemtotal { get; set; }

    public string? Variationreason { get; set; }

    public string? Taxstatuscodevalue { get; set; }

    public decimal? Paiditemamount { get; set; }

    public decimal? Paiditemgst { get; set; }

    public decimal? Paiditemtotal { get; set; }

    public decimal? Paidsurcharge { get; set; }
}
