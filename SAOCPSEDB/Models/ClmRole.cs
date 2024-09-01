﻿using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRole
{
    public int Claimid { get; set; }

    public int Roleno { get; set; }

    public string? Roletype { get; set; }

    public int? Userid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Deleted { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmRolehistory> ClmRolehistories { get; set; } = new List<ClmRolehistory>();

    public virtual SecUser? User { get; set; }
}
