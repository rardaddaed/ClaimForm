using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayPaymentX
{
    public int Paymentid { get; set; }

    public string? Agencyreference { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual PayPayment Payment { get; set; } = null!;
}
