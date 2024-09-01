using System.ComponentModel.DataAnnotations;

namespace SAOCPSEDB.Models;

public partial class DmsDocument
{
    [Key]
    public int Documentid { get; set; }

    public string? Documentnumber { get; set; }

    public DateTime? Dateregistered { get; set; }

    public int? Registeredby { get; set; }

    public string? Filename { get; set; }

    public short? Checkedout { get; set; }

    public int? Checkedoutby { get; set; }

    public DateTime? Checkoutdatetime { get; set; }

    public string? Checkoutprefix { get; set; }

    public string? Description { get; set; }

    public byte[]? Timestamp { get; set; }

    public short? Documentreviewed { get; set; }

    public int? Reviewedby { get; set; }

    public DateTime? Datereviewed { get; set; }

    public DateTime? Timereviewed { get; set; }

    public virtual ICollection<AdmEmailtemplatedocument> AdmEmailtemplatedocuments { get; set; } = new List<AdmEmailtemplatedocument>();

    public virtual ICollection<ClmAuthorisedpersondocument> ClmAuthorisedpersondocuments { get; set; } = new List<ClmAuthorisedpersondocument>();

    public virtual ICollection<ClmCasemanagementplandoc> ClmCasemanagementplandocs { get; set; } = new List<ClmCasemanagementplandoc>();

    public virtual ICollection<ClmClaimtaskdocument> ClmClaimtaskdocuments { get; set; } = new List<ClmClaimtaskdocument>();

    public virtual ICollection<ClmEarningsdocument> ClmEarningsdocuments { get; set; } = new List<ClmEarningsdocument>();

    public virtual ICollection<ClmInvestigation> ClmInvestigations { get; set; } = new List<ClmInvestigation>();

    public virtual ICollection<ClmLegaldisputeevent> ClmLegaldisputeevents { get; set; } = new List<ClmLegaldisputeevent>();

    public virtual ICollection<ClmLegaldisputetask> ClmLegaldisputetasks { get; set; } = new List<ClmLegaldisputetask>();

    public virtual ICollection<ClmMotorvehicle> ClmMotorvehicles { get; set; } = new List<ClmMotorvehicle>();

    public virtual ICollection<ClmPermimpairSa> ClmPermimpairSas { get; set; } = new List<ClmPermimpairSa>();

    public virtual ICollection<ClmPiawedocument> ClmPiawedocuments { get; set; } = new List<ClmPiawedocument>();

    public virtual ICollection<ClmRiskassessmentdoc> ClmRiskassessmentdocs { get; set; } = new List<ClmRiskassessmentdoc>();

    public virtual ICollection<ClmRtwassessmentX> ClmRtwassessmentXes { get; set; } = new List<ClmRtwassessmentX>();

    public virtual ICollection<ClmTreatmentdocument> ClmTreatmentdocuments { get; set; } = new List<ClmTreatmentdocument>();

    public virtual ICollection<ClmWitness> ClmWitnesses { get; set; } = new List<ClmWitness>();

    public virtual ICollection<ClmfrmClaimdocumentX> ClmfrmClaimdocumentXes { get; set; } = new List<ClmfrmClaimdocumentX>();

    public virtual ICollection<CorIndocument> CorIndocuments { get; set; } = new List<CorIndocument>();

    public virtual ICollection<CorOutdocument> CorOutdocuments { get; set; } = new List<CorOutdocument>();

    public virtual ICollection<DmsDocumentreviewhistory> DmsDocumentreviewhistories { get; set; } = new List<DmsDocumentreviewhistory>();

    public virtual ICollection<DmsPersonrespClaim> DmsPersonrespClaims { get; set; } = new List<DmsPersonrespClaim>();

    public virtual ICollection<DmsPersonresponsiblehistory> DmsPersonresponsiblehistories { get; set; } = new List<DmsPersonresponsiblehistory>();

    public virtual ICollection<DmsRevision> DmsRevisions { get; set; } = new List<DmsRevision>();

    public virtual ICollection<EmlAttachment> EmlAttachments { get; set; } = new List<EmlAttachment>();

    public virtual ICollection<EmlinAttachment> EmlinAttachments { get; set; } = new List<EmlinAttachment>();

    public virtual ICollection<EvtDocumentX> EvtDocumentXes { get; set; } = new List<EvtDocumentX>();

    public virtual ICollection<EvtInvestigationdocX> EvtInvestigationdocXes { get; set; } = new List<EvtInvestigationdocX>();

    public virtual ICollection<EvtPdfX> EvtPdfXes { get; set; } = new List<EvtPdfX>();

    public virtual ICollection<EvtStatushistorydocX> EvtStatushistorydocXes { get; set; } = new List<EvtStatushistorydocX>();

    public virtual ICollection<FnDocument> FnDocuments { get; set; } = new List<FnDocument>();

    public virtual ICollection<GevtDocumentX> GevtDocumentXes { get; set; } = new List<GevtDocumentX>();

    public virtual ICollection<GevtPdfX> GevtPdfXes { get; set; } = new List<GevtPdfX>();

    public virtual ICollection<ImpDocument> ImpDocuments { get; set; } = new List<ImpDocument>();

    public virtual ICollection<IncDocumentX> IncDocumentXes { get; set; } = new List<IncDocumentX>();

    public virtual ICollection<IncInvestigationdocumentX> IncInvestigationdocumentXes { get; set; } = new List<IncInvestigationdocumentX>();

    public virtual ICollection<IncReviewsummaryX> IncReviewsummaryXes { get; set; } = new List<IncReviewsummaryX>();

    public virtual ICollection<IncdocFilequeueX> IncdocFilequeueXes { get; set; } = new List<IncdocFilequeueX>();

    public virtual ICollection<LegLegalentityX> LegLegalentityXes { get; set; } = new List<LegLegalentityX>();

    public virtual ICollection<MedDocument> MedDocuments { get; set; } = new List<MedDocument>();

    public virtual ICollection<PayPayment> PayPayments { get; set; } = new List<PayPayment>();

    public virtual ICollection<PorInjuredworkerassociateddocumentX> PorInjuredworkerassociateddocumentXes { get; set; } = new List<PorInjuredworkerassociateddocumentX>();

    public virtual ICollection<PorProviderassociateddocumentX> PorProviderassociateddocumentXes { get; set; } = new List<PorProviderassociateddocumentX>();

    public virtual ICollection<PorUserX> PorUserXes { get; set; } = new List<PorUserX>();

    public virtual ICollection<PorUserassociateddocumentX> PorUserassociateddocumentXes { get; set; } = new List<PorUserassociateddocumentX>();

    public virtual ICollection<RecRecovery> RecRecoveries { get; set; } = new List<RecRecovery>();

    public virtual ICollection<RehDocument> RehDocuments { get; set; } = new List<RehDocument>();

    public virtual ICollection<RptDocument> RptDocuments { get; set; } = new List<RptDocument>();

    public virtual ICollection<SecUserCommon> SecUserCommons { get; set; } = new List<SecUserCommon>();

    public virtual ICollection<SecUserdocumentX> SecUserdocumentXes { get; set; } = new List<SecUserdocumentX>();

    public virtual ICollection<SubDocument> SubDocuments { get; set; } = new List<SubDocument>();

    public virtual ICollection<SubReturnSa> SubReturnSas { get; set; } = new List<SubReturnSa>();
}
