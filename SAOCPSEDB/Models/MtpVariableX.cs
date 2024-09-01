using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MtpVariableX
{
    public int Masterpieceid { get; set; }

    public int Variableno { get; set; }

    public string? Variable { get; set; }

    public string? Subvariable { get; set; }

    public string? Value { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual MtpMasterpieceX Masterpiece { get; set; } = null!;
}
