using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtInvestigationdocX
{
    public int Eventid { get; set; }

    public int Docno { get; set; }

    public int? Documentid { get; set; }

    public short? Privilegedandconfidential { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;
}
