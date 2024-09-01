using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayItem
{
    public int Paymentid { get; set; }

    public int Itemno { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public string? Estimatecategory { get; set; }

    public string? Itemstatus { get; set; }

    public int? Accountid { get; set; }

    public string? Taxstatus { get; set; }

    public decimal? Itemamount { get; set; }

    public decimal? Itemgst { get; set; }

    public decimal? Itemtotal { get; set; }

    public decimal? Paiditemamount { get; set; }

    public decimal? Paiditemgst { get; set; }

    public decimal? Paiditemtotal { get; set; }

    public int? Workcoverreportable { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GlAccount? Account { get; set; }

    public virtual ICollection<ClmTreatmentitem> ClmTreatmentitems { get; set; } = new List<ClmTreatmentitem>();

    public virtual PayCompitem? PayCompitem { get; set; }

    public virtual PayDraftitem? PayDraftitem { get; set; }

    public virtual PayInvoiceitem? PayInvoiceitem { get; set; }

    public virtual ICollection<PayItemsubentry> PayItemsubentries { get; set; } = new List<PayItemsubentry>();

    public virtual ICollection<PayItemtransaction> PayItemtransactions { get; set; } = new List<PayItemtransaction>();

    public virtual PayPayment Payment { get; set; } = null!;
}
