using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MtpFundprofileX
{
    public int Fundprofileid { get; set; }

    public string? Profilename { get; set; }

    public string? Accountnumber { get; set; }

    public short? Defaultprofile { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Active { get; set; }

    public string? Claimtype { get; set; }

    public virtual ICollection<MtpFundaccountX> MtpFundaccountXes { get; set; } = new List<MtpFundaccountX>();

    public virtual ICollection<MtpFundorgstructX> MtpFundorgstructXes { get; set; } = new List<MtpFundorgstructX>();

    public virtual ICollection<PayInvoiceitemX> PayInvoiceitemXes { get; set; } = new List<PayInvoiceitemX>();
}
