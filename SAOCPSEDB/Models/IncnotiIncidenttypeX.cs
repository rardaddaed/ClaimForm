using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncnotiIncidenttypeX
{
    public int Incnotiid { get; set; }

    public int Incidenttypeno { get; set; }

    public string? Incidenttype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncnotiIncidentnotificationX Incnoti { get; set; } = null!;
}
