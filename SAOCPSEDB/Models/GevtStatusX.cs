using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtStatusX
{
    public int Geventid { get; set; }

    public string? Status { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public int? Hrid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtEventX Gevent { get; set; } = null!;

    public virtual HrDatum? Hr { get; set; }
}
