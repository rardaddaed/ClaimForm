using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayTransaction
{
    public int Paymentid { get; set; }

    public int Transactionno { get; set; }

    public int? Transactionid { get; set; }

    public short? Selected { get; set; }

    public decimal? Matchedamount { get; set; }

    public int? Accountid { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GlAccount? Account { get; set; }

    public virtual PayPayment Payment { get; set; } = null!;

    public virtual GlTransaction? Transaction { get; set; }
}
