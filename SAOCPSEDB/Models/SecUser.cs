using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecUser
{
    public int Userid { get; set; }

    public short? Active { get; set; }

    public string? Logonid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Ldapname { get; set; }

    public byte[]? Password { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Firstandlastname { get; set; }

    public virtual ICollection<ClmCasemanagementplan> ClmCasemanagementplans { get; set; } = new List<ClmCasemanagementplan>();

    public virtual ICollection<ClmClaim1> ClmClaim1s { get; set; } = new List<ClmClaim1>();

    public virtual ICollection<ClmClaimtask> ClmClaimtasks { get; set; } = new List<ClmClaimtask>();

    public virtual ICollection<ClmClassificationhistory> ClmClassificationhistories { get; set; } = new List<ClmClassificationhistory>();

    public virtual ICollection<ClmDeterminationSa> ClmDeterminationSas { get; set; } = new List<ClmDeterminationSa>();

    public virtual ICollection<ClmDeterminationhistorySa> ClmDeterminationhistorySas { get; set; } = new List<ClmDeterminationhistorySa>();

    public virtual ICollection<ClmEarning> ClmEarnings { get; set; } = new List<ClmEarning>();

    public virtual ICollection<ClmEstimate> ClmEstimates { get; set; } = new List<ClmEstimate>();

    public virtual ICollection<ClmEstimateworksheet> ClmEstimateworksheetAppliedbyNavigations { get; set; } = new List<ClmEstimateworksheet>();

    public virtual ICollection<ClmEstimateworksheet> ClmEstimateworksheetEnteredbyNavigations { get; set; } = new List<ClmEstimateworksheet>();

    public virtual ICollection<ClmFiletracking> ClmFiletrackings { get; set; } = new List<ClmFiletracking>();

    public virtual ICollection<ClmLegaldisputetaskresp> ClmLegaldisputetaskresps { get; set; } = new List<ClmLegaldisputetaskresp>();

    public virtual ICollection<ClmLegaldisputetask> ClmLegaldisputetasks { get; set; } = new List<ClmLegaldisputetask>();

    public virtual ICollection<ClmPaymentrestriction> ClmPaymentrestrictions { get; set; } = new List<ClmPaymentrestriction>();

    public virtual ICollection<ClmPiawe> ClmPiaweAuthorisedbies { get; set; } = new List<ClmPiawe>();

    public virtual ICollection<ClmPiawe> ClmPiaweEnteredbies { get; set; } = new List<ClmPiawe>();

    public virtual ICollection<ClmPiawe> ClmPiaweFinalisedbies { get; set; } = new List<ClmPiawe>();

    public virtual ICollection<ClmPiawemodifyhistory> ClmPiawemodifyhistories { get; set; } = new List<ClmPiawemodifyhistory>();

    public virtual ICollection<ClmPurchaseauth> ClmPurchaseauths { get; set; } = new List<ClmPurchaseauth>();

    public virtual ICollection<ClmPurchaseitem> ClmPurchaseitems { get; set; } = new List<ClmPurchaseitem>();

    public virtual ICollection<ClmPurchaseorder> ClmPurchaseorders { get; set; } = new List<ClmPurchaseorder>();

    public virtual ICollection<ClmRecoveryestimate> ClmRecoveryestimates { get; set; } = new List<ClmRecoveryestimate>();

    public virtual ICollection<ClmRegistrationhistory> ClmRegistrationhistories { get; set; } = new List<ClmRegistrationhistory>();

    public virtual ICollection<ClmRegistration> ClmRegistrations { get; set; } = new List<ClmRegistration>();

    public virtual ICollection<ClmRehabstatus> ClmRehabstatuses { get; set; } = new List<ClmRehabstatus>();

    public virtual ICollection<ClmRehabstatushistory> ClmRehabstatushistories { get; set; } = new List<ClmRehabstatushistory>();

    public virtual ICollection<ClmRiskassessment> ClmRiskassessments { get; set; } = new List<ClmRiskassessment>();

    public virtual ICollection<ClmRolehistory> ClmRolehistoryChangedbyNavigations { get; set; } = new List<ClmRolehistory>();

    public virtual ICollection<ClmRolehistory> ClmRolehistoryUsers { get; set; } = new List<ClmRolehistory>();

    public virtual ICollection<ClmRole> ClmRoles { get; set; } = new List<ClmRole>();

    public virtual ICollection<ClmRtwassessmentX> ClmRtwassessmentXes { get; set; } = new List<ClmRtwassessmentX>();

    public virtual ICollection<ClmRtwstatus> ClmRtwstatuses { get; set; } = new List<ClmRtwstatus>();

    public virtual ICollection<ClmRtwstatushistory> ClmRtwstatushistories { get; set; } = new List<ClmRtwstatushistory>();

    public virtual ICollection<ClmServiceX> ClmServiceXes { get; set; } = new List<ClmServiceX>();

    public virtual ICollection<ClmSmsmessage> ClmSmsmessages { get; set; } = new List<ClmSmsmessage>();

    public virtual ICollection<ClmSmsrecipient> ClmSmsrecipients { get; set; } = new List<ClmSmsrecipient>();

    public virtual ICollection<ClmStatus> ClmStatuses { get; set; } = new List<ClmStatus>();

    public virtual ICollection<ClmStatushistory> ClmStatushistories { get; set; } = new List<ClmStatushistory>();

    public virtual ICollection<ClmTreatment> ClmTreatmentAuthorisedbyNavigations { get; set; } = new List<ClmTreatment>();

    public virtual ICollection<ClmTreatment> ClmTreatmentEnteredbyNavigations { get; set; } = new List<ClmTreatment>();

    public virtual ICollection<ClmTreatment> ClmTreatmentStatuschangebyNavigations { get; set; } = new List<ClmTreatment>();

    public virtual ICollection<ClmTreatmentstatushistory> ClmTreatmentstatushistories { get; set; } = new List<ClmTreatmentstatushistory>();

    public virtual ICollection<CorCorrespondencein> CorCorrespondenceins { get; set; } = new List<CorCorrespondencein>();

    public virtual ICollection<CorCorrespondenceout> CorCorrespondenceouts { get; set; } = new List<CorCorrespondenceout>();

    public virtual ICollection<EmlEmail> EmlEmailEnteredbyNavigations { get; set; } = new List<EmlEmail>();

    public virtual ICollection<EmlEmail> EmlEmailSentbyNavigations { get; set; } = new List<EmlEmail>();

    public virtual ICollection<EmlinAttachment> EmlinAttachmentPersonresponsibleusers { get; set; } = new List<EmlinAttachment>();

    public virtual ICollection<EmlinAttachment> EmlinAttachmentProcessedbyusers { get; set; } = new List<EmlinAttachment>();

    public virtual ICollection<EmlinAttachmentpersonresponsiblehistory> EmlinAttachmentpersonresponsiblehistories { get; set; } = new List<EmlinAttachmentpersonresponsiblehistory>();

    public virtual ICollection<FnFilenote> FnFilenotes { get; set; } = new List<FnFilenote>();

    public virtual ICollection<FnResponsibility> FnResponsibilities { get; set; } = new List<FnResponsibility>();

    public virtual ICollection<GlAccount> GlAccountEnteredbyusers { get; set; } = new List<GlAccount>();

    public virtual ICollection<GlAccount> GlAccountUpdatedbyusers { get; set; } = new List<GlAccount>();

    public virtual ICollection<ImpInjurymanagementplan> ImpInjurymanagementplans { get; set; } = new List<ImpInjurymanagementplan>();

    public virtual ICollection<IncIncidentX1> IncIncidentX1s { get; set; } = new List<IncIncidentX1>();

    public virtual ICollection<IncIncidentuserX> IncIncidentuserXes { get; set; } = new List<IncIncidentuserX>();

    public virtual ICollection<IncNotificationsX> IncNotificationsXes { get; set; } = new List<IncNotificationsX>();

    public virtual ICollection<IncRejectX> IncRejectXRejectedbyusers { get; set; } = new List<IncRejectX>();

    public virtual ICollection<IncRejectX> IncRejectXReviewerusers { get; set; } = new List<IncRejectX>();

    public virtual ICollection<IncReviewX> IncReviewXes { get; set; } = new List<IncReviewX>();

    public virtual ICollection<IncReviewsummaryX> IncReviewsummaryXes { get; set; } = new List<IncReviewsummaryX>();

    public virtual ICollection<IncStatusX> IncStatusXes { get; set; } = new List<IncStatusX>();

    public virtual ICollection<IncStatushistoryX> IncStatushistoryXes { get; set; } = new List<IncStatushistoryX>();

    public virtual InsInsurer? InsInsurer { get; set; }

    public virtual ICollection<JobJob> JobJobs { get; set; } = new List<JobJob>();

    public virtual ICollection<ParBank> ParBankEnteredbyNavigations { get; set; } = new List<ParBank>();

    public virtual ICollection<ParBank> ParBankModifiedbyNavigations { get; set; } = new List<ParBank>();

    public virtual ICollection<ParContacthistory> ParContacthistories { get; set; } = new List<ParContacthistory>();

    public virtual ICollection<ParFinance> ParFinances { get; set; } = new List<ParFinance>();

    public virtual ICollection<ParFinstatushistory> ParFinstatushistories { get; set; } = new List<ParFinstatushistory>();

    public virtual ICollection<ParLocationhistory> ParLocationhistories { get; set; } = new List<ParLocationhistory>();

    public virtual ICollection<PayDraft> PayDrafts { get; set; } = new List<PayDraft>();

    public virtual ICollection<PayPayment> PayPaymentAuthorisedbies { get; set; } = new List<PayPayment>();

    public virtual ICollection<PayPayment> PayPaymentDeclinedbies { get; set; } = new List<PayPayment>();

    public virtual ICollection<PayPayment> PayPaymentEnteredbies { get; set; } = new List<PayPayment>();

    public virtual ICollection<PayPaymentmodifyhistory> PayPaymentmodifyhistories { get; set; } = new List<PayPaymentmodifyhistory>();

    public virtual ICollection<PorInjuredworkerX> PorInjuredworkerXManagerusers { get; set; } = new List<PorInjuredworkerX>();

    public virtual ICollection<PorInjuredworkerX> PorInjuredworkerXRequestedbyusers { get; set; } = new List<PorInjuredworkerX>();

    public virtual ICollection<PorInjuredworkerX> PorInjuredworkerXReviewedbyusers { get; set; } = new List<PorInjuredworkerX>();

    public virtual ICollection<PorProviderX> PorProviderXManagerusers { get; set; } = new List<PorProviderX>();

    public virtual ICollection<PorProviderX> PorProviderXRequestedbyusers { get; set; } = new List<PorProviderX>();

    public virtual ICollection<PorProviderX> PorProviderXReviewedbyusers { get; set; } = new List<PorProviderX>();

    public virtual ICollection<PorProvideractionhistoryX> PorProvideractionhistoryXActionbyusers { get; set; } = new List<PorProvideractionhistoryX>();

    public virtual ICollection<PorProvideractionhistoryX> PorProvideractionhistoryXRequestedbyusers { get; set; } = new List<PorProvideractionhistoryX>();

    public virtual ICollection<PorUserX> PorUserXManagerusers { get; set; } = new List<PorUserX>();

    public virtual ICollection<PorUserX> PorUserXRequestedbyusers { get; set; } = new List<PorUserX>();

    public virtual ICollection<PorUserX> PorUserXReviewedbyusers { get; set; } = new List<PorUserX>();

    public virtual ICollection<PorUserX> PorUserXSupervisorusers { get; set; } = new List<PorUserX>();

    public virtual ICollection<RecRecovery> RecRecoveryEnteredbyusers { get; set; } = new List<RecRecovery>();

    public virtual ICollection<RecRecovery> RecRecoveryFinalisedbyusers { get; set; } = new List<RecRecovery>();

    public virtual ICollection<RehRehabX> RehRehabXes { get; set; } = new List<RehRehabX>();

    public virtual ICollection<SchSchedule> SchScheduleEnteredbyNavigations { get; set; } = new List<SchSchedule>();

    public virtual ICollection<SchSchedule> SchScheduleModifiedbyNavigations { get; set; } = new List<SchSchedule>();

    public virtual ICollection<SecAudit> SecAudits { get; set; } = new List<SecAudit>();

    public virtual ICollection<SecClaimexclusionsX> SecClaimexclusionsXes { get; set; } = new List<SecClaimexclusionsX>();

    public virtual ICollection<SecClaiminclusionsX> SecClaiminclusionsXes { get; set; } = new List<SecClaiminclusionsX>();

    public virtual ICollection<SecHistory> SecHistories { get; set; } = new List<SecHistory>();

    public virtual ICollection<SecOrgstructX> SecOrgstructXes { get; set; } = new List<SecOrgstructX>();

    public virtual SecPassword? SecPassword { get; set; }

    public virtual ICollection<SecUserCommon> SecUserCommonEnteredbyNavigations { get; set; } = new List<SecUserCommon>();

    public virtual ICollection<SecUserCommon> SecUserCommonModifiedbyNavigations { get; set; } = new List<SecUserCommon>();

    public virtual ICollection<SecUserCommon> SecUserCommonSupervisorusers { get; set; } = new List<SecUserCommon>();

    public virtual SecUserCommon? SecUserCommonUser { get; set; }

    public virtual SecUserEventtypeX? SecUserEventtypeX { get; set; }

    public virtual SecUserX? SecUserX { get; set; }

    public virtual ICollection<SecUserdocumentX> SecUserdocumentXes { get; set; } = new List<SecUserdocumentX>();

    public virtual ICollection<SecUserpositionCommon> SecUserpositionCommonEnteredbyNavigations { get; set; } = new List<SecUserpositionCommon>();

    public virtual ICollection<SecUserpositionCommon> SecUserpositionCommonModifiedbyNavigations { get; set; } = new List<SecUserpositionCommon>();

    public virtual ICollection<SecUserposition> SecUserpositions { get; set; } = new List<SecUserposition>();

    public virtual ICollection<TeamUsersX> TeamUsersXes { get; set; } = new List<TeamUsersX>();
}
