using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HirmAccessattemptX
{
    public int Accessattemptid { get; set; }

    public DateTime? Attemptdatetime { get; set; }

    public int? Attemptnumber { get; set; }

    public string? Username { get; set; }

    public string? Givenames { get; set; }

    public string? Surname { get; set; }

    public string? Employeenumber { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public int? Whsconsultant { get; set; }

    public string? Agency { get; set; }

    public string? Ipaddress { get; set; }

    public string? Stage { get; set; }

    public DateTime? Stagedatetime { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdatetime { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<HirmAccesstokenX> HirmAccesstokenXes { get; set; } = new List<HirmAccesstokenX>();

    public virtual ICollection<HirmIpblockX> HirmIpblockXes { get; set; } = new List<HirmIpblockX>();
}
