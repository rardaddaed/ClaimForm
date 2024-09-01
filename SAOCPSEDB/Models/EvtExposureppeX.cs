using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtExposureppeX
{
    public int Eventid { get; set; }

    public int Ppeno { get; set; }

    public string? Ppetype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
