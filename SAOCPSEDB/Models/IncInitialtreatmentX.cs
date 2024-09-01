using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncInitialtreatmentX
{
    public int Incidentid { get; set; }

    public int? Initialtreatment { get; set; }

    public string? Description { get; set; }

    public int? Assistancerequired { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Injuryillnessdescription { get; set; }

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
