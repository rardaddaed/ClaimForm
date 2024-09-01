using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncnotiCorrectiveactiontypeX
{
    public int Incnotiid { get; set; }

    public int Correctiveactiontypeno { get; set; }

    public string? Correctiveactiontype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncnotiIncidentnotificationX Incnoti { get; set; } = null!;
}
