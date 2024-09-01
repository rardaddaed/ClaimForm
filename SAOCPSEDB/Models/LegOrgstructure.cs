using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class LegOrgstructure
{
    public int Legalentityid { get; set; }

    public int Orgstructno { get; set; }

    public int? Jurisdiction { get; set; }

    public int? Orgstructid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual LegLegalentity Legalentity { get; set; } = null!;

    public virtual OsOrgstructure? Orgstruct { get; set; }
}
