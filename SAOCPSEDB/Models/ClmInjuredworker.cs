﻿using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmInjuredworker
{
    public int Claimid { get; set; }

    public int? Partyid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Actbehalf { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ParEmployee? Party { get; set; }
}
