using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmIncidentX
{
    public int Claimid { get; set; }

    public short? Policecclaim { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public DateTime? Firstnotifieddate { get; set; }

    public virtual ClmIncident Claim { get; set; } = null!;
}
