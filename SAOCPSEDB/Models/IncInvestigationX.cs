using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncInvestigationX
{
    public int Incidentid { get; set; }

    public DateTime? Datecommenced { get; set; }

    public DateTime? Datedue { get; set; }

    public DateTime? Datecompleted { get; set; }

    public DateTime? Dateclosed { get; set; }

    public int? Consultedhsrep { get; set; }

    public int? Representativeconsultedid { get; set; }

    public DateTime? Consultdate { get; set; }

    public string? Consultcomments { get; set; }

    public int? Injurytype { get; set; }

    public string? Injuryside { get; set; }

    public string? Bodilylocation1codetype { get; set; }

    public string? Bodilylocation1 { get; set; }

    public string? Bodilylocation2codetype { get; set; }

    public string? Bodilylocation2 { get; set; }

    public string? Bodilylocation3codetype { get; set; }

    public string? Bodilylocation3 { get; set; }

    public string? Nature1codetype { get; set; }

    public string? Nature1 { get; set; }

    public string? Nature2codetype { get; set; }

    public string? Nature2 { get; set; }

    public string? Mechanism1codetype { get; set; }

    public string? Mechanism1 { get; set; }

    public string? Mechanism2codetype { get; set; }

    public string? Mechanism2 { get; set; }

    public string? Agency1codetype { get; set; }

    public string? Agency1 { get; set; }

    public string? Agency2codetype { get; set; }

    public string? Agency2 { get; set; }

    public string? Description { get; set; }

    public int? Aware { get; set; }

    public string? Awaredetails { get; set; }

    public int? Areasafe { get; set; }

    public string? Areasafedetails { get; set; }

    public int? Firsttime { get; set; }

    public string? Recurrencedetails { get; set; }

    public int? Assessmentconducted { get; set; }

    public int? Involvehumanbiofactors { get; set; }

    public int? Involvebodyfluid { get; set; }

    public int? Involveskin { get; set; }

    public int? Involveneedle { get; set; }

    public int? Involvepsych { get; set; }

    public int? Involveviolence { get; set; }

    public int? Involvestress { get; set; }

    public int? Involvefall { get; set; }

    public int? Involvesubstance { get; set; }

    public int? Isnotifiable { get; set; }

    public int? Regulatornotified { get; set; }

    public string? Regulatornotifieddetails { get; set; }

    public int? Isdangerous { get; set; }

    public string? Exposuretype { get; set; }

    public int? Regulatornotifieddangerous { get; set; }

    public string? Regulatornotifieddangerousdetails { get; set; }

    public int? Iselectrical { get; set; }

    public int? Electricalhasnotified { get; set; }

    public string? Electricalhasnotifieddetails { get; set; }

    public int? Sitepreserved { get; set; }

    public string? Severity { get; set; }

    public string? Likelihood { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? Dateinvestigationactionscompleted { get; set; }

    public DateTime? Regulatorreporteddate { get; set; }

    public DateTime? Regulatorreportedtime { get; set; }

    public string? Regulatoridnumber { get; set; }

    public string? Regulatorfilenumber { get; set; }

    public int? Leadinvestigatorid { get; set; }

    public short? Externalinvestigation { get; set; }

    public string? Externalinvestigationdetails { get; set; }

    public int? Reviewerhrid { get; set; }

    public virtual ICollection<IncInvestigationreasonX> IncInvestigationreasonXes { get; set; } = new List<IncInvestigationreasonX>();

    public virtual ICollection<IncInvestigationteamX> IncInvestigationteamXes { get; set; } = new List<IncInvestigationteamX>();

    public virtual IncIncidentX1 Incident { get; set; } = null!;

    public virtual IncHrdataX? Leadinvestigator { get; set; }

    public virtual IncHrdataX? Representativeconsulted { get; set; }

    public virtual IncHrdataX? Reviewerhr { get; set; }
}
