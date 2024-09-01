using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtStatusX
{
    public int Eventid { get; set; }

    public string? Status { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public int? Hrid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual HrDatum? Hr { get; set; }
}
