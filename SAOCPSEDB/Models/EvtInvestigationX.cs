using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtInvestigationX
{
    public int Eventid { get; set; }

    public DateTime? Statusdatetime { get; set; }

    public DateTime? Datecommenced { get; set; }

    public DateTime? Investigationduedate { get; set; }

    public short? Investigationcomplete { get; set; }

    public int? Completedbyhrid { get; set; }

    public DateTime? Datecompleted { get; set; }

    public int? Whsconsultanthrid { get; set; }

    public string? Hsrconsulted { get; set; }

    public int? Hsrhrid { get; set; }

    public string? Consultationdetails { get; set; }

    public short? Haspinbeenissued { get; set; }

    public string? Detailsofpin { get; set; }

    public short? Referredtoextbody { get; set; }

    public DateTime? Datereferred { get; set; }

    public string? Responsibleforextinvestigation { get; set; }

    public string? Actiontaken { get; set; }

    public string? Explainothersawareofevent { get; set; }

    public short? Firsttimereported { get; set; }

    public string? Recurrencewhynoteffective { get; set; }

    public short? Debriefinggiven { get; set; }

    public DateTime? Internaldate { get; set; }

    public DateTime? Externaldate { get; set; }

    public short? Isassisstancerequired { get; set; }

    public string? Assisstanceprovided { get; set; }

    public short? Requireregulatornotification { get; set; }

    public short? Sitepreserved { get; set; }

    public short? Eliminaterisk { get; set; }

    public short? Substitutehazard { get; set; }

    public short? Isolatehazard { get; set; }

    public short? Reducerisk { get; set; }

    public short? Reduceexposure { get; set; }

    public short? Provideppe { get; set; }

    public short? Nochangeproposed { get; set; }

    public string? Nochangeproposedreason { get; set; }

    public short? Hazardcontrolled { get; set; }

    public string? Controlmeasures { get; set; }

    public string? Immediateaction { get; set; }

    public short? Hazardrequirereassessment { get; set; }

    public string? Reassessmentpersonresp { get; set; }

    public DateTime? Reassessmentduedate { get; set; }

    public string? Levelofharm { get; set; }

    public string? Likelihoodofharm { get; set; }

    public string? Detailedinvestigationrequired { get; set; }

    public short? Correctiveactionplanrequired { get; set; }

    public string? Whynocorrectiveaction { get; set; }

    public int? Feedbackprovided { get; set; }

    public DateTime? Datefeedbackprovided { get; set; }

    public string? Whynofeedbackprovided { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Riskrating { get; set; }

    public virtual HrDatum? Completedbyhr { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual HrDatum? Hsrhr { get; set; }

    public virtual HrDatum? Whsconsultanthr { get; set; }
}
