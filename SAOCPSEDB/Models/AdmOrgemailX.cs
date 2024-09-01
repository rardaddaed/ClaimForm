using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmOrgemailX
{
    public int Orgemailid { get; set; }

    public int? Orgstructid { get; set; }

    public string? Email { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual OsOrgstructure? Orgstruct { get; set; }
}
