using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AudAudit
{
    public int AuditId { get; set; }

    public DateTime AudDatetime { get; set; }

    public string Userlogon { get; set; } = null!;

    public string Tablename { get; set; } = null!;

    public int? Idcol { get; set; }

    public byte[]? Timestamp { get; set; }

    public byte[]? SourceTimestamp { get; set; }

    public string? Activity { get; set; }
}
