using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayPayee
{
    public int Paymentid { get; set; }

    public int Payeeno { get; set; }

    public int? Partyid { get; set; }

    public int? Partylocationno { get; set; }

    public int? Partybankno { get; set; }

    public string? Payeerole { get; set; }

    public string? Abn { get; set; }

    public string? Addressline1 { get; set; }

    public string? Addressline2 { get; set; }

    public string? Addressline3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? International { get; set; }

    public string? Country { get; set; }

    public short? Reimbursement { get; set; }

    public DateTime? Invoicedate { get; set; }

    public DateTime? Invoicereceiveddate { get; set; }

    public string? Invoicenumber { get; set; }

    public decimal? Invoiceamount { get; set; }

    public decimal? Invoicegst { get; set; }

    public decimal? Invoicetotal { get; set; }

    public decimal? Authorisedamount { get; set; }

    public decimal? Authorisedgst { get; set; }

    public decimal? Authorisedtotal { get; set; }

    public string? Transactiontype { get; set; }

    public int? Transactionid { get; set; }

    public short? Transferred { get; set; }

    public DateTime? Datetransferred { get; set; }

    public short? Manuallyprocessed { get; set; }

    public short? Paid { get; set; }

    public DateTime? Datepaid { get; set; }

    public string? Chequeeftnumber { get; set; }

    public short? Presented { get; set; }

    public DateTime? Datepresented { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public decimal? Paygwithheldamount { get; set; }

    public short? Paygapplies { get; set; }

    public string? Email { get; set; }

    public virtual ParBank? ParBank { get; set; }

    public virtual ParLocation? ParLocation { get; set; }

    public virtual ParParty? Party { get; set; }

    public virtual PayDraftpayee? PayDraftpayee { get; set; }

    public virtual PayPayeeX? PayPayeeX { get; set; }

    public virtual PayPayment Payment { get; set; } = null!;

    public virtual GlTransaction? Transaction { get; set; }
}
