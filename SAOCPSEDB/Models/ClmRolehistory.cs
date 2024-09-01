using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRolehistory
{
    public int Claimid { get; set; }

    public int Roleno { get; set; }

    public int Rolehistoryno { get; set; }

    public DateTime? Daterolechanged { get; set; }

    public string? Roletype { get; set; }

    public int? Userid { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ClmRole ClmRole { get; set; } = null!;

    public virtual SecUser? User { get; set; }
}
