using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtInvestigatorsX
{
    public int Eventid { get; set; }

    public int Investigatorno { get; set; }

    public int? Hrid { get; set; }

    public short? Islead { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual HrDatum? Hr { get; set; }
}
