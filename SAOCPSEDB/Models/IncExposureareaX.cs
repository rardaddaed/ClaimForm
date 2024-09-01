using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncExposureareaX
{
    public int Incidentid { get; set; }

    public int Areano { get; set; }

    public string? Areatype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncExposureX Incident { get; set; } = null!;
}
