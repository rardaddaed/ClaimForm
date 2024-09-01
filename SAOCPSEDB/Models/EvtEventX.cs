using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtEventX
{
    public int Eventid { get; set; }

    public string? Eventnumber { get; set; }

    public short? Confidential { get; set; }

    public DateTime? Dateofevent { get; set; }

    public DateTime? Timeofevent { get; set; }

    public DateTime? Datereported { get; set; }

    public DateTime? Timereported { get; set; }

    public string? Reportedby { get; set; }

    public string? Reportedbyname { get; set; }

    public string? Reportedcontactnumber { get; set; }

    public string? Reportedemail { get; set; }

    public string? Reportedemporgname { get; set; }

    public string? Reportedagencycontact { get; set; }

    public string? Reportedtoname { get; set; }

    public DateTime? Datenotified { get; set; }

    public int? Enteredbyhrid { get; set; }

    public DateTime? Dateentered { get; set; }

    public string? Eventtype { get; set; }

    public string? Location { get; set; }

    public string? Specificarea { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Description { get; set; }

    public string? Hazardcategory { get; set; }

    public string? Environmentdetails { get; set; }

    public string? Environmentotherdetails { get; set; }

    public string? Propertydamagetype { get; set; }

    public string? Propertydamagedescription { get; set; }

    public decimal? Propertydamageestimate { get; set; }

    public string? Securitydescription { get; set; }

    public string? Exposureactivity { get; set; }

    public string? Exposurecause { get; set; }

    public string? Exposuresubstance { get; set; }

    public string? Exposureextent { get; set; }

    public int? Numberofaggressors { get; set; }

    public string? Aggressorphysicalviolence { get; set; }

    public string? Aggressorverbalabuse { get; set; }

    public string? Aggressorbehaviouralviolence { get; set; }

    public int? Aggressorpropertyviolence { get; set; }

    public short? Immediateactionnoact { get; set; }

    public string? Immediateactiondetails { get; set; }

    public int? Immediateactionhrid { get; set; }

    public int? Orgstructid { get; set; }

    public int? Supervisorhrid { get; set; }

    public int? Reviewerhrid { get; set; }

    public int? Hsrephrid { get; set; }

    public int? Whsconsultanthrid { get; set; }

    public string? Severityinjury { get; set; }

    public string? Severitylikelihood { get; set; }

    public string? Howdidtheyfeel { get; set; }

    public string? Sleepleadinguptoevent { get; set; }

    public string? Qualityofsleep { get; set; }

    public string? Physicalfatigue { get; set; }

    public string? Mentalfatigue { get; set; }

    public short? Fitforworkattime { get; set; }

    public string? Notfitreason { get; set; }

    public int? Immediatethreat { get; set; }

    public int? Involvenatureofwork { get; set; }

    public int? Involveworkplaceconflict { get; set; }

    public int? Involveworkperformance { get; set; }

    public int? Involveworkconditions { get; set; }

    public string? Eventsleadingto { get; set; }

    public int? Psychisrecurrence { get; set; }

    public string? Psychrecurrencehowlong { get; set; }

    public int? Psychpreexistingcondition { get; set; }

    public int? Eapprovided { get; set; }

    public string? Fbtype { get; set; }

    public DateTime? Fbdateacknowledged { get; set; }

    public string? Fboriginatingmethod { get; set; }

    public short? Fbrelatedtoaccommodation { get; set; }

    public short? Fbwanttobecontacted { get; set; }

    public string? Fbpreferredcontactmethod { get; set; }

    public short? Fbremainanonymous { get; set; }

    public string? Clseverityrating { get; set; }

    public string? Clstaffaffected { get; set; }

    public string? Cleventnumber { get; set; }

    public short? Clfamilymembercontacted { get; set; }

    public DateTime? Cldateofsubmission { get; set; }

    public string? Cldetailsofcontactresponse { get; set; }

    public short? Clpolicecontacted { get; set; }

    public string? Clreportnumber { get; set; }

    public DateTime? Cldateofcontact { get; set; }

    public string? Claggressionassault { get; set; }

    public string? Clbehaviour { get; set; }

    public string? Clcareconcern { get; set; }

    public string? Clstatuschange { get; set; }

    public string? Cldeathclassification { get; set; }

    public string? Cltypeofdeath { get; set; }

    public string? Clemergencycode { get; set; }

    public string? Cltypeoffall { get; set; }

    public string? Clhealthissue { get; set; }

    public string? Cldescriptionofinjury { get; set; }

    public string? Clbodilylocationofinjury { get; set; }

    public string? Clinitialtreatmenttype { get; set; }

    public string? Cltreatmentdetails { get; set; }

    public string? Clfraudtype { get; set; }

    public string? Clinfectioncontrol { get; set; }

    public string? Clmedicationerror { get; set; }

    public string? Clmotoreventtype { get; set; }

    public string? Clroadconditions { get; set; }

    public string? Clvehicletype { get; set; }

    public string? Clvehicleeventwhen { get; set; }

    public decimal? Clvehiclecostofdamage { get; set; }

    public string? Clbusinessinterruption { get; set; }

    public string? Clequipmentproductsupplies { get; set; }

    public string? Clpropertyevent { get; set; }

    public string? Clpropertytype { get; set; }

    public decimal? Clpropertycostofdamage { get; set; }

    public string? Clsecurityeventclassification { get; set; }

    public string? Clsecurityeventtype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Severityrating { get; set; }

    public int? Fbcomplaintinvestigatorhrid { get; set; }

    public int? Fbcomplaintreviewerhrid { get; set; }

    public int? Fbagencyadministratorhrid { get; set; }

    public int? Fbpersonresponsiblenotificationhrid { get; set; }

    public int? Convertedfromguesteventid { get; set; }

    public DateTime? Datetimeconvertedfromguest { get; set; }

    public string? Guesteventnumber { get; set; }

    public string? Guestevententeredemail { get; set; }

    public string? Guesteventactiontakenbyname { get; set; }

    public string? Fbcomplainttheme { get; set; }

    public string? Fbcomplaintsubcat1 { get; set; }

    public string? Fbcomplaintsubcat2 { get; set; }

    public string? Clreportableincident { get; set; }

    public int? Clclientadministratorhrid { get; set; }

    public short? Deleted { get; set; }

    public DateTime? Lastsaveddatetime { get; set; }

    public string? Cltinjurydescription { get; set; }

    public string? Cltinjurylocation { get; set; }

    public string? Clttreatmenttype { get; set; }

    public string? Clthospitalvisit { get; set; }

    public string? Clttreatmentdetail { get; set; }
}
