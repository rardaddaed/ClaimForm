using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtAggressionassaultX
{
    public int Geventid { get; set; }

    public int Typeno { get; set; }

    public string? Aggressiontype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtEventX Gevent { get; set; } = null!;
}
