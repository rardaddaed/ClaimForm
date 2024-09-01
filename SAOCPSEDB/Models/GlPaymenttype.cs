using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GlPaymenttype
{
    public int Accountid { get; set; }

    public int Paymenttypeno { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public int? Jurisdictionzone { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Claimtype { get; set; }

    public virtual GlAccount Account { get; set; } = null!;
}
