using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AudAuditdatum
{
    public int AuditId { get; set; }

    public string ColName { get; set; } = null!;

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int Changed { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
