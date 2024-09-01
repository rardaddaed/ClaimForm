using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtReferredagencyX
{
    public int Eventid { get; set; }

    public int Agencyno { get; set; }

    public string? Agency { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
