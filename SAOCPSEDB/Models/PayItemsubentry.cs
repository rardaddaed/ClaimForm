using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayItemsubentry
{
    public int Paymentid { get; set; }

    public int Itemno { get; set; }

    public int Itemsubentryno { get; set; }

    public int? Transactionid { get; set; }

    public int? Subentryno { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual GlSubentry? GlSubentry { get; set; }

    public virtual PayItem PayItem { get; set; } = null!;
}
