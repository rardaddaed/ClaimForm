using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfxTimeframe
{
    public int Wfxworkflowid { get; set; }

    public int Wfxtimeframeno { get; set; }

    public string? Entitytype { get; set; }

    public int? Entityid { get; set; }

    public DateTime? Datesatisfied { get; set; }

    public DateTime? Duedate { get; set; }

    public int? Active { get; set; }

    public int? Overdueprocessed { get; set; }

    public DateTime? Previousduedate { get; set; }

    public string? Notes { get; set; }

    public int? Workflowid { get; set; }

    public int? Timeframeno { get; set; }

    public DateTime? Dateapplied { get; set; }

    public DateTime? Datesatisfiedprocessed { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WfxWorkflow Wfxworkflow { get; set; } = null!;
}
