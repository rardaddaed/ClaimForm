using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecOrgstructX
{
    public int Userid { get; set; }

    public int Orgstructno { get; set; }

    public int? Jurisdictionzone { get; set; }

    public int? Orgstructid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser User { get; set; } = null!;
}
