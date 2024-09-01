using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRiskassessment
{
    public int Claimid { get; set; }

    public int Riskassessmentno { get; set; }

    public DateTime? Dateofriskassessment { get; set; }

    public string? Riskassessmenttype { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredbyuserid { get; set; }

    public int? Totalscore { get; set; }

    public string? Claimrating { get; set; }

    public int? Employeescore { get; set; }

    public string? Employeecomments { get; set; }

    public int? Psychosocialscore { get; set; }

    public string? Psychosocialcomments { get; set; }

    public int? Employmentscore { get; set; }

    public string? Employmentcomments { get; set; }

    public int? Rehabilitationscore { get; set; }

    public string? Rehabilitationcomments { get; set; }

    public int? Treatmentprovidersscore { get; set; }

    public string? Treatmentproviderscomments { get; set; }

    public int? Casemanagementscore { get; set; }

    public string? Casemanagementcomments { get; set; }

    public int? Legalscore { get; set; }

    public string? Legalcomments { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmRiskassessmentdoc> ClmRiskassessmentdocs { get; set; } = new List<ClmRiskassessmentdoc>();

    public virtual ICollection<ClmRiskassessmentfactor> ClmRiskassessmentfactors { get; set; } = new List<ClmRiskassessmentfactor>();

    public virtual SecUser? Enteredbyuser { get; set; }
}
