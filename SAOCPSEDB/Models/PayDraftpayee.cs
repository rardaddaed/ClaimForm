using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayDraftpayee
{
    public int Paymentid { get; set; }

    public int Payeeno { get; set; }

    public string? Providername { get; set; }

    public string? Providervendornumber { get; set; }

    public string? Providerabn { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public Guid? Portalguid { get; set; }

    public Guid? Portalbusinessguid { get; set; }

    public string? Bsb1 { get; set; }

    public string? Bsb2 { get; set; }

    public string? Accountnumber { get; set; }

    public virtual PayPayee PayPayee { get; set; } = null!;

    public virtual PayPayment Payment { get; set; } = null!;
}
