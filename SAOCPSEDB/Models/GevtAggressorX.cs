using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtAggressorX
{
    public int Geventid { get; set; }

    public int Aggressorno { get; set; }

    public string? Relationship { get; set; }

    public string? Nameofaggressor { get; set; }

    public int? Previousdisturbances { get; set; }

    public int? Ageofaggressor { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtEventX Gevent { get; set; } = null!;
}
