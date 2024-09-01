using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncIncidentX1
{
    public int Incidentid { get; set; }

    public string? Incidentnumber { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Timeentered { get; set; }

    public int? Reportedbyid { get; set; }

    public string? Reportedbyempno { get; set; }

    public string? Reportedbyfirstname { get; set; }

    public string? Reportedbysurname { get; set; }

    public int? Incidenttype { get; set; }

    public int? Environmental { get; set; }

    public int? Propertydamage { get; set; }

    public int? Security { get; set; }

    public int? Motorvehicle { get; set; }

    public int? Nonworkrelatedincident { get; set; }

    public int? Involvesinjuryillness { get; set; }

    public string? Mechanismofhazardincident { get; set; }

    public string? Environmenttype { get; set; }

    public string? Pdtypeofdamage { get; set; }

    public string? Pdotherdetails { get; set; }

    public string? Pddamagedescription { get; set; }

    public string? Securitytype { get; set; }

    public string? Securityotherdetails { get; set; }

    public string? Securitydescription { get; set; }

    public DateTime? Dateofincident { get; set; }

    public DateTime? Timeofincident { get; set; }

    public DateTime? Dateadvised { get; set; }

    public DateTime? Timeadvised { get; set; }

    public int? Isrepeat { get; set; }

    public int? Isrecurrence { get; set; }

    public int? Reportedtoid { get; set; }

    public string? Location { get; set; }

    public string? Specificarea { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? Noknownsuburb { get; set; }

    public string? Description { get; set; }

    public int? Actiontakenbyid { get; set; }

    public string? Actiontakendescription { get; set; }

    public int? Orgstructid { get; set; }

    public int? Notificationsuperid { get; set; }

    public int? Notificationmanagerid { get; set; }

    public int? Notificationwhsuserid { get; set; }

    public int? Hashs { get; set; }

    public int? Notificationhsid { get; set; }

    public string? Severity { get; set; }

    public string? Likelihood { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Haswitnesses { get; set; }

    public short? Vehicletype { get; set; }

    public short? Vehicledetailsunknown { get; set; }

    public string? Vehicleregistrationnumber { get; set; }

    public string? Vehiclefleetnumber { get; set; }

    public string? Vehicleotherdetails { get; set; }

    public short? Psychological { get; set; }

    public short? Nearmiss { get; set; }

    public string? Securitysitelocation { get; set; }

    public string? Securitysitelocationother { get; set; }

    public short? Offender { get; set; }

    public short? Mentalillness { get; set; }

    public short? Alcoholaffected { get; set; }

    public short? Drugaffected { get; set; }

    public short? Coronarelated { get; set; }

    public virtual IncHrdataX? Actiontakenby { get; set; }

    public virtual IncActionplanX? IncActionplanX { get; set; }

    public virtual IncAggressiondetailsX? IncAggressiondetailsX { get; set; }

    public virtual ICollection<IncAltinvestigatorX> IncAltinvestigatorXes { get; set; } = new List<IncAltinvestigatorX>();

    public virtual ICollection<IncCovidisolationX> IncCovidisolationXes { get; set; } = new List<IncCovidisolationX>();

    public virtual IncDetailsX? IncDetailsX { get; set; }

    public virtual ICollection<IncDocumentX> IncDocumentXes { get; set; } = new List<IncDocumentX>();

    public virtual IncExposureX? IncExposureX { get; set; }

    public virtual IncFallsliptripX? IncFallsliptripX { get; set; }

    public virtual ICollection<IncFurtherfindingX> IncFurtherfindingXes { get; set; } = new List<IncFurtherfindingX>();

    public virtual IncInitialtreatmentX? IncInitialtreatmentX { get; set; }

    public virtual IncInvestigationX? IncInvestigationX { get; set; }

    public virtual ICollection<IncInvestigationdocumentX> IncInvestigationdocumentXes { get; set; } = new List<IncInvestigationdocumentX>();

    public virtual IncInvestigationpartbX? IncInvestigationpartbX { get; set; }

    public virtual ICollection<IncInvestigationreviewX> IncInvestigationreviewXes { get; set; } = new List<IncInvestigationreviewX>();

    public virtual IncManualtaskX? IncManualtaskX { get; set; }

    public virtual ICollection<IncNotificationsX> IncNotificationsXes { get; set; } = new List<IncNotificationsX>();

    public virtual IncPersoninvolvedX? IncPersoninvolvedX { get; set; }

    public virtual IncPsychologicalX? IncPsychologicalX { get; set; }

    public virtual ICollection<IncRejectX> IncRejectXes { get; set; } = new List<IncRejectX>();

    public virtual IncReviewX? IncReviewX { get; set; }

    public virtual IncSapolX? IncSapolX { get; set; }

    public virtual ICollection<IncSecuritycontroltypeX> IncSecuritycontroltypeXes { get; set; } = new List<IncSecuritycontroltypeX>();

    public virtual IncStatusX? IncStatusX { get; set; }

    public virtual ICollection<IncStatushistoryX> IncStatushistoryXes { get; set; } = new List<IncStatushistoryX>();

    public virtual ICollection<IncWitnessX> IncWitnessXes { get; set; } = new List<IncWitnessX>();

    public virtual IncHrdataX? Notificationhs { get; set; }

    public virtual IncHrdataX? Notificationmanager { get; set; }

    public virtual IncHrdataX? Notificationsuper { get; set; }

    public virtual SecUser? Notificationwhsuser { get; set; }

    public virtual OsOrgstructure? Orgstruct { get; set; }

    public virtual IncHrdataX? Reportedby { get; set; }

    public virtual IncHrdataX? Reportedto { get; set; }
}
