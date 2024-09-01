using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecAudit
{
    public int Attemptid { get; set; }

    public DateTime? Datetimeoccurred { get; set; }

    public string? Username { get; set; }

    public int? Validuser { get; set; }

    public string? Modulename { get; set; }

    public int? Successfullogin { get; set; }

    public string? Ipaddress { get; set; }

    public int? Userid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? User { get; set; }
}
