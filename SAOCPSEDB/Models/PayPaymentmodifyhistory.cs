using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayPaymentmodifyhistory
{
    public int Paymentid { get; set; }

    public int Modifyno { get; set; }

    public DateTime? Datemodified { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? ModifiedbyNavigation { get; set; }

    public virtual PayPayment Payment { get; set; } = null!;
}
