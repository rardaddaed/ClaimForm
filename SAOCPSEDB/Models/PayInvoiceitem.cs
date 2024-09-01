using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayInvoiceitem
{
    public int Paymentid { get; set; }

    public int Itemno { get; set; }

    public int? Serviceproviderpartyid { get; set; }

    public string? Supplierreference { get; set; }

    public DateTime? Servicedate { get; set; }

    public string? Itemnumber { get; set; }

    public string? Itemdescription { get; set; }

    public string? Itemnumbersource { get; set; }

    public decimal? Scheduledamount { get; set; }

    public decimal? Surcharge { get; set; }

    public decimal? Quantity { get; set; }

    public string? Variationreason { get; set; }

    public decimal? Paidsurcharge { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual PayInvoiceitemX? PayInvoiceitemX { get; set; }

    public virtual PayItem PayItem { get; set; } = null!;

    public virtual PayPayment Payment { get; set; } = null!;

    public virtual ParParty? Serviceproviderparty { get; set; }
}
