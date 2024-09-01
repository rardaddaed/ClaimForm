using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtSecuritycontrolX
{
    public int Eventid { get; set; }

    public int Typeno { get; set; }

    public string? Controltype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
