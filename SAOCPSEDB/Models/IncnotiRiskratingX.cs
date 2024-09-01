using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncnotiRiskratingX
{
    public int Incnotiid { get; set; }

    public int Riskratingno { get; set; }

    public string? Riskrating { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncnotiIncidentnotificationX Incnoti { get; set; } = null!;
}
