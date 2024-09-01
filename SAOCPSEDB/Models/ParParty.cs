using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParParty
{
    public int Partyid { get; set; }

    public string? Partytype { get; set; }

    public int? Active { get; set; }

    public string? Familyname { get; set; }

    public string? Givennames { get; set; }

    public string? Preferredname { get; set; }

    public string? Otherpreviousnames { get; set; }

    public string? Title { get; set; }

    public string? Maritalstatus { get; set; }

    public string? Companyname { get; set; }

    public string? Providername { get; set; }

    public string? Namechangereason { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public int? Numberofchilddependants { get; set; }

    public int? Numberofotherdependants { get; set; }

    public int? Identifiedasaboriginal { get; set; }

    public int? Identifiedastsislander { get; set; }

    public string? Countrycodetype { get; set; }

    public string? Countryofbirth { get; set; }

    public string? Languagecodetype { get; set; }

    public string? Language { get; set; }

    public int? Interpreterrequired { get; set; }

    public string? Specialcommunicationneeds { get; set; }

    public string? Gender { get; set; }

    public int? Allowemailcorrespondence { get; set; }

    public string? Preferredcontactmethod { get; set; }

    public string? Abn { get; set; }

    public string? Acn { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Middlenames { get; set; }

    public virtual ICollection<ClmCompensationrecipient> ClmCompensationrecipients { get; set; } = new List<ClmCompensationrecipient>();

    public virtual ICollection<ClmDependant> ClmDependants { get; set; } = new List<ClmDependant>();

    public virtual ICollection<ClmInvestigation> ClmInvestigations { get; set; } = new List<ClmInvestigation>();

    public virtual ICollection<ClmLegalrep> ClmLegalreps { get; set; } = new List<ClmLegalrep>();

    public virtual ICollection<ClmNominateddoctor> ClmNominateddoctors { get; set; } = new List<ClmNominateddoctor>();

    public virtual ICollection<ClmProvider> ClmProviders { get; set; } = new List<ClmProvider>();

    public virtual ICollection<ClmReferral> ClmReferrals { get; set; } = new List<ClmReferral>();

    public virtual ICollection<ClmRtwassessmentX> ClmRtwassessmentXes { get; set; } = new List<ClmRtwassessmentX>();

    public virtual ICollection<ClmfrmClaimX> ClmfrmClaimXes { get; set; } = new List<ClmfrmClaimX>();

    public virtual ICollection<EmlinProviderdocument> EmlinProviderdocuments { get; set; } = new List<EmlinProviderdocument>();

    public virtual ICollection<GlTransaction> GlTransactions { get; set; } = new List<GlTransaction>();

    public virtual ICollection<ImpInjurymanagementplan> ImpInjurymanagementplanNominatedtreatingdoctors { get; set; } = new List<ImpInjurymanagementplan>();

    public virtual ICollection<ImpInjurymanagementplan> ImpInjurymanagementplanRehabilitationproviders { get; set; } = new List<ImpInjurymanagementplan>();

    public virtual ICollection<IncIncidentuserX> IncIncidentuserXes { get; set; } = new List<IncIncidentuserX>();

    public virtual ICollection<MedMedcert> MedMedcerts { get; set; } = new List<MedMedcert>();

    public virtual ICollection<ParBank> ParBanks { get; set; } = new List<ParBank>();

    public virtual ParBusiness? ParBusiness { get; set; }

    public virtual ICollection<ParContact> ParContacts { get; set; } = new List<ParContact>();

    public virtual ICollection<ParCorrespondencein> ParCorrespondenceins { get; set; } = new List<ParCorrespondencein>();

    public virtual ParEmployee? ParEmployee { get; set; }

    public virtual ParEmployeeSa? ParEmployeeSa { get; set; }

    public virtual ICollection<ParEmployeenamehistory> ParEmployeenamehistories { get; set; } = new List<ParEmployeenamehistory>();

    public virtual ICollection<ParEmployeenumberhistoryX> ParEmployeenumberhistoryXes { get; set; } = new List<ParEmployeenumberhistoryX>();

    public virtual ParFinance? ParFinance { get; set; }

    public virtual ICollection<ParLocation> ParLocations { get; set; } = new List<ParLocation>();

    public virtual ICollection<ParNumber> ParNumbers { get; set; } = new List<ParNumber>();

    public virtual ParPartyX? ParPartyX { get; set; }

    public virtual ParProvider? ParProvider { get; set; }

    public virtual ICollection<ParProvidertypenumber> ParProvidertypenumbers { get; set; } = new List<ParProvidertypenumber>();

    public virtual ICollection<ParProvidertype> ParProvidertypes { get; set; } = new List<ParProvidertype>();

    public virtual ICollection<ParSpecialtyX> ParSpecialtyXes { get; set; } = new List<ParSpecialtyX>();

    public virtual ICollection<PayCompensationrecipient> PayCompensationrecipients { get; set; } = new List<PayCompensationrecipient>();

    public virtual ICollection<PayInvoiceitem> PayInvoiceitems { get; set; } = new List<PayInvoiceitem>();

    public virtual ICollection<PayPayee> PayPayees { get; set; } = new List<PayPayee>();

    public virtual ICollection<RehRehabX> RehRehabXNominatedtreatingdoctors { get; set; } = new List<RehRehabX>();

    public virtual ICollection<RehRehabX> RehRehabXRtwproviders { get; set; } = new List<RehRehabX>();
}
