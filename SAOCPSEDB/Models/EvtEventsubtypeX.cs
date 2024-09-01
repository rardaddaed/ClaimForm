using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtEventsubtypeX
{
    public int Eventid { get; set; }

    public int Typeno { get; set; }

    public string? Eventtype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
