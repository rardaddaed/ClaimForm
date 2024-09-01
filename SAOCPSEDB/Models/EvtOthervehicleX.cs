using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtOthervehicleX
{
    public int Eventid { get; set; }

    public int Othervehicleno { get; set; }

    public string? Othervehicletype { get; set; }

    public string? Othervehiclemake { get; set; }

    public string? Othervehiclemodel { get; set; }

    public string? Otherregistrationno { get; set; }

    public string? Otherfullnameofdriver { get; set; }

    public string? Otherlicencenumber { get; set; }

    public string? Othercontactdetails { get; set; }

    public string? Otherinsurancedetails { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
