using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncAltinvestigatorX
{
    public int Incidentid { get; set; }

    public int Investigatorno { get; set; }

    public int? Inchrid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncHrdataX? Inchr { get; set; }

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
