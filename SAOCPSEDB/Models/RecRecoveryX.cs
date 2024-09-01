using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RecRecoveryX
{
    public int Recoveryid { get; set; }

    public string? Paymentcategory { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual RecRecovery Recovery { get; set; } = null!;
}
