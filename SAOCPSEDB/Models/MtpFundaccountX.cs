using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MtpFundaccountX
{
    public int Fundprofileid { get; set; }

    public int Fundaccountno { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public string? Accountnumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual MtpFundprofileX Fundprofile { get; set; } = null!;
}
