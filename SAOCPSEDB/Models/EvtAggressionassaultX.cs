using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtAggressionassaultX
{
    public int Eventid { get; set; }

    public int Typeno { get; set; }

    public string? Aggressiontype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
