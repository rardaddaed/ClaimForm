using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncFurtherfindingX
{
    public int Incidentid { get; set; }

    public int Findingno { get; set; }

    public string? Summary { get; set; }

    public DateTime? Datecompleted { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
