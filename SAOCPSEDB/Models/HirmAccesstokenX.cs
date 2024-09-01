using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HirmAccesstokenX
{
    public int Accesstokenid { get; set; }

    public string? Tokentype { get; set; }

    public string? Token { get; set; }

    public DateTime? Createdatetime { get; set; }

    public DateTime? Expiredatetime { get; set; }

    public int? Accessattemptid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual HirmAccessattemptX? Accessattempt { get; set; }
}
