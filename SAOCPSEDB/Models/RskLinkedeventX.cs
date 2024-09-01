using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RskLinkedeventX
{
    public int Riskid { get; set; }

    public int Linkedeventno { get; set; }

    public int? Eventid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1? Event { get; set; }
}
