using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtExposureppeX
{
    public int Geventid { get; set; }

    public int Ppeno { get; set; }

    public string? Ppetype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtEventX Gevent { get; set; } = null!;
}
