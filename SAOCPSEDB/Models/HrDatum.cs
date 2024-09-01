using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HrDatum
{
    public int Hrid { get; set; }

    public int? Partyid { get; set; }

    public int? Active { get; set; }

    public string? Employeenumber { get; set; }

    public string? Familyname { get; set; }

    public string? Givennames { get; set; }

    public string? Title { get; set; }

    public string? Maritalstatus { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public int? Numberofchilddependants { get; set; }

    public int? Numberofotherdependants { get; set; }

    public int? Identifiedasaboriginal { get; set; }

    public int? Identifiedastsislander { get; set; }

    public string? Countryofbirth { get; set; }

    public string? Language { get; set; }

    public int? Interpreterrequired { get; set; }

    public string? Gender { get; set; }

    public DateTime? Employmentstartdate { get; set; }

    public int? Exemployee { get; set; }

    public DateTime? Employmentenddate { get; set; }

    public string? Employmentendreason { get; set; }

    public string? Residentialaddressline1 { get; set; }

    public string? Residentialaddressline2 { get; set; }

    public string? Residentialaddressline3 { get; set; }

    public string? Residentialsuburb { get; set; }

    public string? Residentialstate { get; set; }

    public string? Residentialpostcode { get; set; }

    public int? Residentialinternational { get; set; }

    public string? Residentialcountry { get; set; }

    public int? Postalsameasresidential { get; set; }

    public string? Postaladdressline1 { get; set; }

    public string? Postaladdressline2 { get; set; }

    public string? Postaladdressline3 { get; set; }

    public string? Postalsuburb { get; set; }

    public string? Postalstate { get; set; }

    public string? Postalpostcode { get; set; }

    public int? Postalinternational { get; set; }

    public string? Postalcountry { get; set; }

    public string? Contactname { get; set; }

    public string? Homephone { get; set; }

    public string? Workphone { get; set; }

    public string? Mobilephone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Paymenttype { get; set; }

    public string? Bankname { get; set; }

    public string? Bankbranch { get; set; }

    public string? Accountname { get; set; }

    public string? Bsb1 { get; set; }

    public string? Bsb2 { get; set; }

    public string? Accountnumber { get; set; }

    public string? Specialrequirements { get; set; }

    public int? Orgstructid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? Datelastupdated { get; set; }

    public DateTime? Datelastsynchronised { get; set; }

    public virtual ICollection<EvtActionX> EvtActionXActionenteredbyhrs { get; set; } = new List<EvtActionX>();

    public virtual ICollection<EvtActionX> EvtActionXActionpersonresponsiblehrs { get; set; } = new List<EvtActionX>();

    public virtual ICollection<EvtActionX> EvtActionXCompldetailsenteredbyhrs { get; set; } = new List<EvtActionX>();

    public virtual ICollection<EvtClientinvestigationX> EvtClientinvestigationXes { get; set; } = new List<EvtClientinvestigationX>();

    public virtual ICollection<EvtClosureX> EvtClosureXClosedbyhrs { get; set; } = new List<EvtClosureX>();

    public virtual ICollection<EvtClosureX> EvtClosureXReopenedbyhrs { get; set; } = new List<EvtClosureX>();

    public virtual ICollection<EvtEventX1> EvtEventX1Clclientadministratorhrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Enteredbyhrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Fbagencyadministratorhrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Fbcomplaintinvestigatorhrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Fbcomplaintreviewerhrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Fbpersonresponsiblenotificationhrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Hsrephrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Reviewerhrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Supervisorhrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtEventX1> EvtEventX1Whsconsultanthrs { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<EvtFindingX> EvtFindingXes { get; set; } = new List<EvtFindingX>();

    public virtual ICollection<EvtInvestigationX> EvtInvestigationXCompletedbyhrs { get; set; } = new List<EvtInvestigationX>();

    public virtual ICollection<EvtInvestigationX> EvtInvestigationXHsrhrs { get; set; } = new List<EvtInvestigationX>();

    public virtual ICollection<EvtInvestigationX> EvtInvestigationXWhsconsultanthrs { get; set; } = new List<EvtInvestigationX>();

    public virtual ICollection<EvtInvestigationreviewX> EvtInvestigationreviewXes { get; set; } = new List<EvtInvestigationreviewX>();

    public virtual ICollection<EvtInvestigatorsX> EvtInvestigatorsXes { get; set; } = new List<EvtInvestigatorsX>();

    public virtual ICollection<EvtNotificationcontactX> EvtNotificationcontactXes { get; set; } = new List<EvtNotificationcontactX>();

    public virtual ICollection<EvtPersoninvolvedX> EvtPersoninvolvedXes { get; set; } = new List<EvtPersoninvolvedX>();

    public virtual ICollection<EvtPwresettokenX> EvtPwresettokenXes { get; set; } = new List<EvtPwresettokenX>();

    public virtual ICollection<EvtSecurityX> EvtSecurityXes { get; set; } = new List<EvtSecurityX>();

    public virtual ICollection<EvtStatusX> EvtStatusXes { get; set; } = new List<EvtStatusX>();

    public virtual ICollection<EvtStatushistoryX> EvtStatushistoryXes { get; set; } = new List<EvtStatushistoryX>();

    public virtual ICollection<EvtWhsreviewX> EvtWhsreviewXes { get; set; } = new List<EvtWhsreviewX>();

    public virtual ICollection<EvtWitnessX> EvtWitnessXes { get; set; } = new List<EvtWitnessX>();

    public virtual ICollection<GevtEventX> GevtEventXFbagencyadministratorhrs { get; set; } = new List<GevtEventX>();

    public virtual ICollection<GevtEventX> GevtEventXFbcomplaintinvestigatorhrs { get; set; } = new List<GevtEventX>();

    public virtual ICollection<GevtEventX> GevtEventXFbcomplaintreviewerhrs { get; set; } = new List<GevtEventX>();

    public virtual ICollection<GevtEventX> GevtEventXFbpersonresponsiblenotificationhrs { get; set; } = new List<GevtEventX>();

    public virtual ICollection<GevtStatusX> GevtStatusXes { get; set; } = new List<GevtStatusX>();

    public virtual HrDataX? HrDataX { get; set; }

    public virtual HrPasswordX? HrPasswordX { get; set; }

    public virtual ICollection<IfnFilenoteX> IfnFilenoteXes { get; set; } = new List<IfnFilenoteX>();

    public virtual OsOrgstructure? Orgstruct { get; set; }

    public virtual ParEmployee? Party { get; set; }
}
