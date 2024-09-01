using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPurchaseitem
{
    public int Claimid { get; set; }

    public int Purchaseorderno { get; set; }

    public int Purchaseitemno { get; set; }

    public string? Itemnumber { get; set; }

    public int? Quantity { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public int? Accountid { get; set; }

    public decimal? Unitprice { get; set; }

    public decimal? Amount { get; set; }

    public short? Gstapplies { get; set; }

    public decimal? Gstamount { get; set; }

    public decimal? Totalamount { get; set; }

    public int? Transactionid { get; set; }

    public short? Adjustment { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GlAccount? Account { get; set; }

    public virtual ClmPurchaseorder ClmPurchaseorder { get; set; } = null!;

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual GlTransaction? Transaction { get; set; }
}
