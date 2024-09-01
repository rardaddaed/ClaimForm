using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtVehicleinvolvedX
{
    public int Geventid { get; set; }

    public int Vehicleinvolvedno { get; set; }

    public string? Vehicleinvolvedtype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtEventX Gevent { get; set; } = null!;
}
