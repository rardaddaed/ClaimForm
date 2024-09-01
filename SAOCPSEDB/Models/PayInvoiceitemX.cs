using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayInvoiceitemX
{
    public int Paymentid { get; set; }

    public int Itemno { get; set; }

    public string? Specialty { get; set; }

    public int? Fundprofileid { get; set; }

    public string? Accountnumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual MtpFundprofileX? Fundprofile { get; set; }

    public virtual PayInvoiceitem PayInvoiceitem { get; set; } = null!;
}
