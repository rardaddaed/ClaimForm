using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayPayment
{
    public int Paymentid { get; set; }

    public string? Transactiontype { get; set; }

    public string? Paymentstatus { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredbyid { get; set; }

    public short? Authorised { get; set; }

    public DateTime? Dateauthorised { get; set; }

    public int? Authorisedbyid { get; set; }

    public decimal? Authorisedamount { get; set; }

    public decimal? Authorisedgst { get; set; }

    public decimal? Authorisedtotal { get; set; }

    public short? Declinetotalpayment { get; set; }

    public DateTime? Datedeclined { get; set; }

    public int? Declinedbyid { get; set; }

    public DateTime? Datetimedetermined { get; set; }

    public string? Particulars { get; set; }

    public int? Documentid { get; set; }

    public int? Jurisdictionzone { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Costcentreappliedtoid { get; set; }

    public int? Createdfromdraftpaymentid { get; set; }

    public DateTime? Dateautocreated { get; set; }

    public virtual SecUser? Authorisedby { get; set; }

    public virtual ICollection<ClmDraftpayment> ClmDraftpayments { get; set; } = new List<ClmDraftpayment>();

    public virtual ICollection<ClmPayment> ClmPayments { get; set; } = new List<ClmPayment>();

    public virtual OsOrgstructure? Costcentreappliedto { get; set; }

    public virtual SecUser? Declinedby { get; set; }

    public virtual DmsDocument? Document { get; set; }

    public virtual SecUser? Enteredby { get; set; }

    public virtual PayComp? PayComp { get; set; }

    public virtual ICollection<PayCompensationrecipient> PayCompensationrecipients { get; set; } = new List<PayCompensationrecipient>();

    public virtual ICollection<PayCompitem> PayCompitems { get; set; } = new List<PayCompitem>();

    public virtual ICollection<PayCompsuitableduty> PayCompsuitableduties { get; set; } = new List<PayCompsuitableduty>();

    public virtual PayDraft? PayDraft { get; set; }

    public virtual ICollection<PayDraftitem> PayDraftitems { get; set; } = new List<PayDraftitem>();

    public virtual ICollection<PayDraftpayee> PayDraftpayees { get; set; } = new List<PayDraftpayee>();

    public virtual PayInsurerreimbursementIn? PayInsurerreimbursementIn { get; set; }

    public virtual ICollection<PayInvoiceitem> PayInvoiceitems { get; set; } = new List<PayInvoiceitem>();

    public virtual ICollection<PayItem> PayItems { get; set; } = new List<PayItem>();

    public virtual ICollection<PayPayee> PayPayees { get; set; } = new List<PayPayee>();

    public virtual PayPaymentX? PayPaymentX { get; set; }

    public virtual ICollection<PayPaymentmodifyhistory> PayPaymentmodifyhistories { get; set; } = new List<PayPaymentmodifyhistory>();

    public virtual PayReversal? PayReversalPayment { get; set; }

    public virtual ICollection<PayReversal> PayReversalReversespayments { get; set; } = new List<PayReversal>();

    public virtual ICollection<PayTransaction> PayTransactions { get; set; } = new List<PayTransaction>();
}
