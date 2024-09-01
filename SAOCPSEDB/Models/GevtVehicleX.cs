using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtVehicleX
{
    public int Geventid { get; set; }

    public string? Vehroadconditions { get; set; }

    public string? Vehweatherconditions { get; set; }

    public string? Vehiclespeed { get; set; }

    public string? Lengthoftimedriving { get; set; }

    public string? Vehicletype { get; set; }

    public short? Vehicleunregistered { get; set; }

    public string? Vehiclemake { get; set; }

    public string? Vehiclemodel { get; set; }

    public string? Registrationno { get; set; }

    public string? Fleetno { get; set; }

    public string? Fullnameofdriver { get; set; }

    public string? Licencenumber { get; set; }

    public short? Othervehicleunknown { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtEventX Gevent { get; set; } = null!;
}
