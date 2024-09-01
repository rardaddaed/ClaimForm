using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtPsychinvolveX
{
    public int Eventid { get; set; }

    public int Involvedno { get; set; }

    public string? Persontype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
