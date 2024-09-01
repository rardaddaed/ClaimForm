using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtIcamcontribfactorX
{
    public int Eventid { get; set; }

    public int Factorno { get; set; }

    public string? Factorcategory { get; set; }

    public string? Factor { get; set; }

    public string? Factorresult { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
