using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtClbehaviourdefX
{
    public int Eventid { get; set; }

    public int Definitionno { get; set; }

    public string? Definitiontype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
