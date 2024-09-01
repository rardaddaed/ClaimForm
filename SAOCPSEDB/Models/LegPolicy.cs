using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class LegPolicy
{
    public int Legalentityid { get; set; }

    public int Policyno { get; set; }

    public int? Policyid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual LegLegalentity Legalentity { get; set; } = null!;

    public virtual PolPolicy? Policy { get; set; }
}
