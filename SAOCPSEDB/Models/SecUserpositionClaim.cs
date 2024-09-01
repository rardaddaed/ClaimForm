using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecUserpositionClaim
{
    public int Userid { get; set; }

    public int Positionno { get; set; }

    public string? Claimtype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUserposition SecUserposition { get; set; } = null!;
}
