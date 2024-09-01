using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AuthBlocked
{
    public int Blockedid { get; set; }

    public string? Ip { get; set; }

    public string? Mac { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
