using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SiteSiteSa
{
    public int Siteid { get; set; }

    public string? Saicindustry { get; set; }

    public string? Sawicindustry { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SiteSite Site { get; set; } = null!;
}
