using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncHrdataX
{
    public int Inchrid { get; set; }

    public string? Employeenumber { get; set; }

    public string? Surname { get; set; }

    public string? Givenname { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Email { get; set; }

    public int? Active { get; set; }

    public int? Accesslevel { get; set; }

    public string? Preferredname { get; set; }

    public DateTime? Dateofrun { get; set; }

    public int? Hashcode { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public byte[]? Timestamp { get; set; }

    public short? Gender { get; set; }

    public byte[]? Password { get; set; }

    public int? Remoteaccessenabled { get; set; }

    public string? Remoteaccessmobile { get; set; }

    public string? Agencycode { get; set; }

    public string? Level1code { get; set; }

    public string? Level2code { get; set; }

    public virtual ICollection<IncAltinvestigatorX> IncAltinvestigatorXes { get; set; } = new List<IncAltinvestigatorX>();

    public virtual ICollection<IncCorrectiveactionX> IncCorrectiveactionXes { get; set; } = new List<IncCorrectiveactionX>();

    public virtual ICollection<IncIncidentX1> IncIncidentX1Actiontakenbies { get; set; } = new List<IncIncidentX1>();

    public virtual ICollection<IncIncidentX1> IncIncidentX1Notificationhs { get; set; } = new List<IncIncidentX1>();

    public virtual ICollection<IncIncidentX1> IncIncidentX1Notificationmanagers { get; set; } = new List<IncIncidentX1>();

    public virtual ICollection<IncIncidentX1> IncIncidentX1Notificationsupers { get; set; } = new List<IncIncidentX1>();

    public virtual ICollection<IncIncidentX1> IncIncidentX1Reportedbies { get; set; } = new List<IncIncidentX1>();

    public virtual ICollection<IncIncidentX1> IncIncidentX1Reportedtos { get; set; } = new List<IncIncidentX1>();

    public virtual ICollection<IncInvestigationX> IncInvestigationXLeadinvestigators { get; set; } = new List<IncInvestigationX>();

    public virtual ICollection<IncInvestigationX> IncInvestigationXRepresentativeconsulteds { get; set; } = new List<IncInvestigationX>();

    public virtual ICollection<IncInvestigationX> IncInvestigationXReviewerhrs { get; set; } = new List<IncInvestigationX>();

    public virtual ICollection<IncInvestigationpartbX> IncInvestigationpartbXPersonreassessments { get; set; } = new List<IncInvestigationpartbX>();

    public virtual ICollection<IncInvestigationpartbX> IncInvestigationpartbXRepresentatives { get; set; } = new List<IncInvestigationpartbX>();

    public virtual ICollection<IncInvestigationreviewX> IncInvestigationreviewXes { get; set; } = new List<IncInvestigationreviewX>();

    public virtual ICollection<IncNotificationsX> IncNotificationsXes { get; set; } = new List<IncNotificationsX>();

    public virtual ICollection<IncPersoninvolvedX> IncPersoninvolvedXes { get; set; } = new List<IncPersoninvolvedX>();

    public virtual ICollection<IncPsychologicalotherpeopleX> IncPsychologicalotherpeopleXes { get; set; } = new List<IncPsychologicalotherpeopleX>();

    public virtual ICollection<IncRejectX> IncRejectXRejectedbyinchrs { get; set; } = new List<IncRejectX>();

    public virtual ICollection<IncRejectX> IncRejectXReviewerinchrs { get; set; } = new List<IncRejectX>();

    public virtual ICollection<IncReviewX> IncReviewXes { get; set; } = new List<IncReviewX>();

    public virtual ICollection<IncReviewsummaryX> IncReviewsummaryXes { get; set; } = new List<IncReviewsummaryX>();

    public virtual ICollection<IncStatusX> IncStatusXes { get; set; } = new List<IncStatusX>();

    public virtual ICollection<IncStatushistoryX> IncStatushistoryXes { get; set; } = new List<IncStatushistoryX>();

    public virtual ICollection<IncWitnessX> IncWitnessXes { get; set; } = new List<IncWitnessX>();
}
