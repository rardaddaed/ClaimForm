using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncPsychologicalX
{
    public int Incidentid { get; set; }

    public string? Otherdetails { get; set; }

    public string? Eventdescription { get; set; }

    public string? Eventfrequency { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Prioreventdescription { get; set; }

    public virtual ICollection<IncPsychologicalfactorX> IncPsychologicalfactorXes { get; set; } = new List<IncPsychologicalfactorX>();

    public virtual ICollection<IncPsychologicalotherpeopleX> IncPsychologicalotherpeopleXes { get; set; } = new List<IncPsychologicalotherpeopleX>();

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
