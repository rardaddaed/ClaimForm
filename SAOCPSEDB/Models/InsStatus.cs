using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsStatus
{
    public int Insurerloadid { get; set; }

    public int Insstatusno { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public string? Claimstatuscodetype { get; set; }

    public string? Claimstatus { get; set; }

    public DateTime? Statusfromdate { get; set; }

    public DateTime? Statustodate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsInsurerload Insurerload { get; set; } = null!;
}
