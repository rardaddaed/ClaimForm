using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsRecovery
{
    public int Insurerloadid { get; set; }

    public int Insrecoveryno { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public DateTime? Recoverydate { get; set; }

    public string? Recoverytypecodetype { get; set; }

    public string? Recoverytype { get; set; }

    public decimal? Recoveryamount { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsInsurerload Insurerload { get; set; } = null!;
}
