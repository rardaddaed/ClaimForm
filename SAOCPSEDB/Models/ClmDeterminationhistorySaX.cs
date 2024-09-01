using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmDeterminationhistorySaX
{
    public int Claimid { get; set; }

    public int Determinationhistoryno { get; set; }

    public string? Dpcdeterminationcodetype { get; set; }

    public string? Dpcdetermination { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public DateTime? Inactivedate { get; set; }

    public virtual ClmDeterminationhistorySa ClmDeterminationhistorySa { get; set; } = null!;
}
