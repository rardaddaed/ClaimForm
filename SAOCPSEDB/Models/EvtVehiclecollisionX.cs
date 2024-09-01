using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtVehiclecollisionX
{
    public int Eventid { get; set; }

    public int Collisionno { get; set; }

    public string? Details { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
