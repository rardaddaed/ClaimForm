using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncInvestigationpartbX
{
    public int Incidentid { get; set; }

    public string? Executiveoverview { get; set; }

    public string? Hazardtype { get; set; }

    public int? Repconsulted { get; set; }

    public int? Representativeid { get; set; }

    public int? Hazardreassessment { get; set; }

    public int? Personreassessmentid { get; set; }

    public DateTime? Duedate { get; set; }

    public int? Feedbackprovided { get; set; }

    public DateTime? Feedbackdate { get; set; }

    public string? Nofeedbackreason { get; set; }

    public int? Hazardresolved { get; set; }

    public string? Controlmeasure { get; set; }

    public string? Details { get; set; }

    public string? Immediateactiondetails { get; set; }

    public string? Systemofworkdetails { get; set; }

    public string? Layoutandequipmentdetails { get; set; }

    public string? Workenvironmentdetails { get; set; }

    public string? Other { get; set; }

    public string? Individualdetails { get; set; }

    public int? Changetoinduction { get; set; }

    public DateTime? Changetoinductiondate { get; set; }

    public int? Changeintraining { get; set; }

    public DateTime? Changeintrainingdate { get; set; }

    public int? Changetoworkprocedure { get; set; }

    public DateTime? Changetoworkproceduredate { get; set; }

    public int? Equipmods { get; set; }

    public DateTime? Equipmodsdate { get; set; }

    public int? Equipmaintainence { get; set; }

    public DateTime? Equipmaintainencedate { get; set; }

    public int? Jobredesign { get; set; }

    public DateTime? Jobredesigndate { get; set; }

    public int? Otheraction { get; set; }

    public DateTime? Otheractiondate { get; set; }

    public int? Debrief { get; set; }

    public DateTime? Debriefdate { get; set; }

    public int? Workstationadjustments { get; set; }

    public DateTime? Workstationadjustmentsdate { get; set; }

    public int? Nochange { get; set; }

    public string? Preventativeactiondescription { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<IncFactorindividualX> IncFactorindividualXes { get; set; } = new List<IncFactorindividualX>();

    public virtual ICollection<IncFactorlayoutX> IncFactorlayoutXes { get; set; } = new List<IncFactorlayoutX>();

    public virtual ICollection<IncFactorsystemofworkX> IncFactorsystemofworkXes { get; set; } = new List<IncFactorsystemofworkX>();

    public virtual ICollection<IncFactorworkenvironmentX> IncFactorworkenvironmentXes { get; set; } = new List<IncFactorworkenvironmentX>();

    public virtual IncIncidentX1 Incident { get; set; } = null!;

    public virtual IncHrdataX? Personreassessment { get; set; }

    public virtual IncHrdataX? Representative { get; set; }
}
