using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncIncidentX
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
}
