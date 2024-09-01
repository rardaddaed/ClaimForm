using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayReversal
{
    public int Paymentid { get; set; }

    public int? Reversespaymentid { get; set; }

    public string? Reversaltype { get; set; }

    public short? Reversalmethod { get; set; }

    public string? Reason { get; set; }

    public string? Chequeeftnumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual PayPayment Payment { get; set; } = null!;

    public virtual PayPayment? Reversespayment { get; set; }
}
