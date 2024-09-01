using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncAggressiondetailsX
{
    public int Incidentid { get; set; }

    public int? Numberofaggressors { get; set; }

    public string? Degreeofphysical { get; set; }

    public string? Degreeofverbal { get; set; }

    public string? Degreeofbehvaiour { get; set; }

    public int? Propertythreat { get; set; }

    public int? Numberinvolved { get; set; }

    public string? Otherfactors { get; set; }

    public string? Leadingeventdetails { get; set; }

    public int? Debriefinggiven { get; set; }

    public DateTime? Debriefinternaldate { get; set; }

    public DateTime? Debriefexternaldate { get; set; }

    public DateTime? Debriefemployeedate { get; set; }

    public int? Receiveactiontraining { get; set; }

    public int? Actiontrainingyear { get; set; }

    public string? Noactiontrainingdetails { get; set; }

    public int? Receivemanagingtraining { get; set; }

    public int? Managingtrainingyear { get; set; }

    public string? Nomanagingtrainingdetails { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Otheraction { get; set; }

    public virtual ICollection<IncAggressionactionX> IncAggressionactionXes { get; set; } = new List<IncAggressionactionX>();

    public virtual ICollection<IncAggressionaggressorX> IncAggressionaggressorXes { get; set; } = new List<IncAggressionaggressorX>();

    public virtual ICollection<IncAggressionfactorsX> IncAggressionfactorsXes { get; set; } = new List<IncAggressionfactorsX>();

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
