using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncRejectX
{
    public int Incidentid { get; set; }

    public int Rejectno { get; set; }

    public string? Rejectedreason { get; set; }

    public int? Rejectedbyinchrid { get; set; }

    public int? Rejectedbyuserid { get; set; }

    public int? Reviewerinchrid { get; set; }

    public int? Revieweruserid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncIncidentX1 Incident { get; set; } = null!;

    public virtual IncHrdataX? Rejectedbyinchr { get; set; }

    public virtual SecUser? Rejectedbyuser { get; set; }

    public virtual IncHrdataX? Reviewerinchr { get; set; }

    public virtual SecUser? Revieweruser { get; set; }
}
