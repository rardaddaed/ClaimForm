using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncExposureppeX
{
    public int Incidentid { get; set; }

    public int Ppeno { get; set; }

    public string? Ppetype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncExposureX Incident { get; set; } = null!;
}
