using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmDeterminationSaX
{
    public int Claimid { get; set; }

    public string? Dpcdeterminationcodetype { get; set; }

    public string? Dpcdetermination { get; set; }

    public string? Disability { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmDeterminationSa Claim { get; set; } = null!;
}
