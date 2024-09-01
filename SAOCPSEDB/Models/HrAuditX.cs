using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HrAuditX
{
    public int Attemptid { get; set; }

    public DateTime? Datetimeoccurred { get; set; }

    public string? Email { get; set; }

    public int? Validuser { get; set; }

    public string? Modulename { get; set; }

    public int? Successfullogin { get; set; }

    public string? Ipaddress { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
