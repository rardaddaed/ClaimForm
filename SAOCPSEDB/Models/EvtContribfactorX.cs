using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtContribfactorX
{
    public int Eventid { get; set; }

    public int Factorno { get; set; }

    public string? Contributingfactor { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
