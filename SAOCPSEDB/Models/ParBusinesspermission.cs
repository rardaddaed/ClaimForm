using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParBusinesspermission
{
    public int Partyid { get; set; }

    public int Permissionno { get; set; }

    public string? Permissiontype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ParBusiness Party { get; set; } = null!;
}
