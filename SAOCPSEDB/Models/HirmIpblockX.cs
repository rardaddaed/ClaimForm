using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HirmIpblockX
{
    public int Ipblockid { get; set; }

    public string? Ipaddress { get; set; }

    public DateTime? Blockeduntildatetime { get; set; }

    public int? Accessattemptid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual HirmAccessattemptX? Accessattempt { get; set; }
}
