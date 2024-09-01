using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtFilenoteX
{
    public int Eventid { get; set; }

    public int Filenoteno { get; set; }

    public int? Filenoteid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual IfnFilenoteX? Filenote { get; set; }
}
