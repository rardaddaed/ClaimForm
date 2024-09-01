using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MtpBatchnumberX
{
    public int Masterpieceid { get; set; }

    public int Filesuffixno { get; set; }

    public string? Filesuffix { get; set; }

    public int? Lastbatchnumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual MtpMasterpieceX Masterpiece { get; set; } = null!;
}
