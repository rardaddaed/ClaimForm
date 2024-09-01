using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtVehicleinvolvedX
{
    public int Eventid { get; set; }

    public int Vehicleinvolvedno { get; set; }

    public string? Vehicleinvolvedtype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
