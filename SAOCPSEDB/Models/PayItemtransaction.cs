using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayItemtransaction
{
    public int Paymentid { get; set; }

    public int Itemno { get; set; }

    public int Transactionno { get; set; }

    public int? Transactionid { get; set; }

    public decimal? Matchedamount { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual PayItem PayItem { get; set; } = null!;

    public virtual GlTransaction? Transaction { get; set; }
}
