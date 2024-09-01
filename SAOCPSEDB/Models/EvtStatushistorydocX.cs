using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtStatushistorydocX
{
    public int Eventid { get; set; }

    public int Historyno { get; set; }

    public int? Documentid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;
}
