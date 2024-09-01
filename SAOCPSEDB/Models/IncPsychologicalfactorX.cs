using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncPsychologicalfactorX
{
    public int Incidentid { get; set; }

    public int Psychologicalfactorno { get; set; }

    public string? Factor { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncPsychologicalX Incident { get; set; } = null!;
}
