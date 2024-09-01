using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsPayment
{
    public int Insurerloadid { get; set; }

    public int Inspaymentno { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public DateTime? Datereceived { get; set; }

    public DateTime? Dateauthorised { get; set; }

    public DateTime? Datepaid { get; set; }

    public string? Transactiontype { get; set; }

    public string? Paymentcategorycodetype { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttypecodetype { get; set; }

    public string? Paymenttype { get; set; }

    public DateTime? Paymentstartdate { get; set; }

    public DateTime? Paymentenddate { get; set; }

    public int? Dayslost { get; set; }

    public int? Hourslost { get; set; }

    public string? Payee { get; set; }

    public string? Invoicenumber { get; set; }

    public DateTime? Invoicedate { get; set; }

    public DateTime? Dateofservice { get; set; }

    public string? Itemnumber { get; set; }

    public decimal? Grossamount { get; set; }

    public decimal? Gstamount { get; set; }

    public decimal? Netamount { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsInsurerload Insurerload { get; set; } = null!;
}
