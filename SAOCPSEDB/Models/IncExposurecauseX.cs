using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncExposurecauseX
{
    public int Incidentid { get; set; }

    public int Causeno { get; set; }

    public string? Causetype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncExposureX Incident { get; set; } = null!;
}
