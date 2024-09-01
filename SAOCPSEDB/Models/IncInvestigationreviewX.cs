using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncInvestigationreviewX
{
    public int Incidentid { get; set; }

    public int Reviewno { get; set; }

    public string? Rejectedreason { get; set; }

    public short? Furtherinvestigationrequired { get; set; }

    public string? Investigationcomments { get; set; }

    public short? Actionapprassgined { get; set; }

    public string? Actioncomments { get; set; }

    public DateTime? Revieweddate { get; set; }

    public int? Reviewedbyinchrid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncIncidentX1 Incident { get; set; } = null!;

    public virtual IncHrdataX? Reviewedbyinchr { get; set; }
}
