using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MtpOrgstructX
{
    public int Masterpieceid { get; set; }

    public int Orgstructno { get; set; }

    public int? Orgstructid { get; set; }

    public string? Filesuffix { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual MtpMasterpieceX Masterpiece { get; set; } = null!;

    public virtual OsOrgstructure? Orgstruct { get; set; }
}
