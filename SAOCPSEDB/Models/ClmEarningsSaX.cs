using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmEarningsSaX
{
    public int Claimid { get; set; }

    public int Earningsno { get; set; }

    public string? Enterprisebargainingcompensationrate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmEarningsSa ClmEarningsSa { get; set; } = null!;
}
