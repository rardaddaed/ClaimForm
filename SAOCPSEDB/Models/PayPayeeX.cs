using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayPayeeX
{
    public int Paymentid { get; set; }

    public int Payeeno { get; set; }

    public short? Holdcheque { get; set; }

    public string? Batchnumber { get; set; }

    public int? Masterpieceid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual MtpMasterpieceX? Masterpiece { get; set; }

    public virtual PayPayee PayPayee { get; set; } = null!;
}
