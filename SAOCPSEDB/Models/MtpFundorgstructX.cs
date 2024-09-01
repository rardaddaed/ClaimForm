using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MtpFundorgstructX
{
    public int Fundprofileid { get; set; }

    public int Fundorgstructno { get; set; }

    public int? Orgstructid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual MtpFundprofileX Fundprofile { get; set; } = null!;

    public virtual OsOrgstructure? Orgstruct { get; set; }
}
