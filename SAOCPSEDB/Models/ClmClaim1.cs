using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmClaim1
{
    public int Claimid { get; set; }

    public string? Claimnumber { get; set; }

    public int? Jurisdictionzone { get; set; }

    public int? State { get; set; }

    public string? Claimtype { get; set; }

    public string? Claimclassification { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Datereceivedemployer { get; set; }

    public DateTime? Datereceivedinsurer { get; set; }

    public DateTime? Datesignedemployee { get; set; }

    public DateTime? Datesignedemployer { get; set; }

    public DateTime? Dateinsurernotifiedofclaim { get; set; }

    public DateTime? Dateinsurernotifiedofinjury { get; set; }

    public int? Claimisconfidential { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Convertedfromclaimid { get; set; }

    public DateTime? Dateclaimconverted { get; set; }

    public int? Convertedby { get; set; }

    public int? Potentialrecovery { get; set; }

    public int? Potentialcommonlaw { get; set; }

    public virtual ClmAuthorisedperson? ClmAuthorisedperson { get; set; }

    public virtual ICollection<ClmCasemanagementplan> ClmCasemanagementplans { get; set; } = new List<ClmCasemanagementplan>();

    public virtual ClmClaimSa? ClmClaimSa { get; set; }

    public virtual ClmClaimX? ClmClaimX { get; set; }

    public virtual ICollection<ClmClaimtask> ClmClaimtasks { get; set; } = new List<ClmClaimtask>();

    public virtual ICollection<ClmClassificationhistory> ClmClassificationhistories { get; set; } = new List<ClmClassificationhistory>();

    public virtual ICollection<ClmCompensationrecipient> ClmCompensationrecipients { get; set; } = new List<ClmCompensationrecipient>();

    public virtual ICollection<ClmCorrespondencein> ClmCorrespondenceins { get; set; } = new List<ClmCorrespondencein>();

    public virtual ICollection<ClmCorrespondenceout> ClmCorrespondenceouts { get; set; } = new List<ClmCorrespondenceout>();

    public virtual ICollection<ClmCovidisolation> ClmCovidisolations { get; set; } = new List<ClmCovidisolation>();

    public virtual ICollection<ClmDependant> ClmDependants { get; set; } = new List<ClmDependant>();

    public virtual ClmDeterminationSa? ClmDeterminationSa { get; set; }

    public virtual ICollection<ClmDraftpayment> ClmDraftpayments { get; set; } = new List<ClmDraftpayment>();

    public virtual ICollection<ClmEarning> ClmEarnings { get; set; } = new List<ClmEarning>();

    public virtual ICollection<ClmEarningsdocument> ClmEarningsdocuments { get; set; } = new List<ClmEarningsdocument>();

    public virtual ICollection<ClmEmail> ClmEmails { get; set; } = new List<ClmEmail>();

    public virtual ClmEmploymentcurrent? ClmEmploymentcurrent { get; set; }

    public virtual ClmEmploymentdoi? ClmEmploymentdoi { get; set; }

    public virtual ICollection<ClmEstimate> ClmEstimates { get; set; } = new List<ClmEstimate>();

    public virtual ICollection<ClmEstimateworksheet> ClmEstimateworksheets { get; set; } = new List<ClmEstimateworksheet>();

    public virtual ICollection<ClmFilenote> ClmFilenotes { get; set; } = new List<ClmFilenote>();

    public virtual ICollection<ClmFiletracking> ClmFiletrackings { get; set; } = new List<ClmFiletracking>();

    public virtual ICollection<ClmIncapacity> ClmIncapacities { get; set; } = new List<ClmIncapacity>();

    public virtual ClmIncident? ClmIncident { get; set; }

    public virtual ClmInjuredworker? ClmInjuredworker { get; set; }

    public virtual ICollection<ClmInjury> ClmInjuries { get; set; } = new List<ClmInjury>();

    public virtual ICollection<ClmInjurymanagementplan> ClmInjurymanagementplans { get; set; } = new List<ClmInjurymanagementplan>();

    public virtual ClmInsurerIn? ClmInsurerIn { get; set; }

    public virtual ICollection<ClmInsurerreferral> ClmInsurerreferrals { get; set; } = new List<ClmInsurerreferral>();

    public virtual ICollection<ClmInvestigation> ClmInvestigations { get; set; } = new List<ClmInvestigation>();

    public virtual ICollection<ClmLegaldispute> ClmLegaldisputes { get; set; } = new List<ClmLegaldispute>();

    public virtual ClmLegalentity? ClmLegalentity { get; set; }

    public virtual ICollection<ClmLegalrep> ClmLegalreps { get; set; } = new List<ClmLegalrep>();

    public virtual ICollection<ClmMedcert> ClmMedcerts { get; set; } = new List<ClmMedcert>();

    public virtual ICollection<ClmMotorvehicle> ClmMotorvehicles { get; set; } = new List<ClmMotorvehicle>();

    public virtual ICollection<ClmNominateddoctor> ClmNominateddoctors { get; set; } = new List<ClmNominateddoctor>();

    public virtual ICollection<ClmOtheremployment> ClmOtheremployments { get; set; } = new List<ClmOtheremployment>();

    public virtual ICollection<ClmOtherinjurydetail> ClmOtherinjurydetails { get; set; } = new List<ClmOtherinjurydetail>();

    public virtual ClmOtherinjurysummary? ClmOtherinjurysummary { get; set; }

    public virtual ICollection<ClmPaymentrestriction> ClmPaymentrestrictions { get; set; } = new List<ClmPaymentrestriction>();

    public virtual ICollection<ClmPayment> ClmPayments { get; set; } = new List<ClmPayment>();

    public virtual ClmPayroll? ClmPayroll { get; set; }

    public virtual ICollection<ClmPermimpairSa> ClmPermimpairSas { get; set; } = new List<ClmPermimpairSa>();

    public virtual ICollection<ClmPiawe> ClmPiawes { get; set; } = new List<ClmPiawe>();

    public virtual ICollection<ClmProvider> ClmProviders { get; set; } = new List<ClmProvider>();

    public virtual ICollection<ClmPurchaseorder> ClmPurchaseorders { get; set; } = new List<ClmPurchaseorder>();

    public virtual ICollection<ClmRecovery> ClmRecoveries { get; set; } = new List<ClmRecovery>();

    public virtual ICollection<ClmRecoveryestimate> ClmRecoveryestimates { get; set; } = new List<ClmRecoveryestimate>();

    public virtual ICollection<ClmReferral> ClmReferrals { get; set; } = new List<ClmReferral>();

    public virtual ClmRegistration? ClmRegistration { get; set; }

    public virtual ICollection<ClmRegistrationhistory> ClmRegistrationhistories { get; set; } = new List<ClmRegistrationhistory>();

    public virtual ICollection<ClmRehabnote> ClmRehabnotes { get; set; } = new List<ClmRehabnote>();

    public virtual ICollection<ClmRehab> ClmRehabs { get; set; } = new List<ClmRehab>();

    public virtual ClmRehabstatus? ClmRehabstatus { get; set; }

    public virtual ICollection<ClmRehabstatushistory> ClmRehabstatushistories { get; set; } = new List<ClmRehabstatushistory>();

    public virtual ICollection<ClmRiskassessment> ClmRiskassessments { get; set; } = new List<ClmRiskassessment>();

    public virtual ICollection<ClmRolehistory> ClmRolehistories { get; set; } = new List<ClmRolehistory>();

    public virtual ICollection<ClmRole> ClmRoles { get; set; } = new List<ClmRole>();

    public virtual ICollection<ClmRtwassessmentX> ClmRtwassessmentXes { get; set; } = new List<ClmRtwassessmentX>();

    public virtual ClmRtwstatus? ClmRtwstatus { get; set; }

    public virtual ICollection<ClmRtwstatushistory> ClmRtwstatushistories { get; set; } = new List<ClmRtwstatushistory>();

    public virtual ClmSadetailsSa? ClmSadetailsSa { get; set; }

    public virtual ICollection<ClmServiceX> ClmServiceXes { get; set; } = new List<ClmServiceX>();

    public virtual ICollection<ClmSmsrecipient> ClmSmsrecipients { get; set; } = new List<ClmSmsrecipient>();

    public virtual ClmStatus? ClmStatus { get; set; }

    public virtual ICollection<ClmStatushistory> ClmStatushistories { get; set; } = new List<ClmStatushistory>();

    public virtual ICollection<ClmSurgerySa> ClmSurgerySas { get; set; } = new List<ClmSurgerySa>();

    public virtual ICollection<ClmTreatment> ClmTreatments { get; set; } = new List<ClmTreatment>();

    public virtual ICollection<ClmWitness> ClmWitnesses { get; set; } = new List<ClmWitness>();

    public virtual SecUser? ConvertedbyNavigation { get; set; }

    public virtual ClmClaim1? Convertedfromclaim { get; set; }

    public virtual ICollection<DmsPersonrespClaim> DmsPersonrespClaims { get; set; } = new List<DmsPersonrespClaim>();

    public virtual ICollection<EmlinCorrin> EmlinCorrins { get; set; } = new List<EmlinCorrin>();

    public virtual ICollection<EmlinCorrout> EmlinCorrouts { get; set; } = new List<EmlinCorrout>();

    public virtual ICollection<EmlinFilenote> EmlinFilenotes { get; set; } = new List<EmlinFilenote>();

    public virtual ICollection<EmlinMedcert> EmlinMedcerts { get; set; } = new List<EmlinMedcert>();

    public virtual ICollection<EmlinPayment> EmlinPayments { get; set; } = new List<EmlinPayment>();

    public virtual ICollection<EmlinRehab> EmlinRehabs { get; set; } = new List<EmlinRehab>();

    public virtual ICollection<ClmClaim1> InverseConvertedfromclaim { get; set; } = new List<ClmClaim1>();

    public virtual ICollection<SecClaimexclusionsX> SecClaimexclusionsXes { get; set; } = new List<SecClaimexclusionsX>();

    public virtual ICollection<SecClaiminclusionsX> SecClaiminclusionsXes { get; set; } = new List<SecClaiminclusionsX>();

    public virtual ICollection<TeamExclusionsX> TeamExclusionsXes { get; set; } = new List<TeamExclusionsX>();

    public virtual ICollection<TeamInclusionsX> TeamInclusionsXes { get; set; } = new List<TeamInclusionsX>();
}
