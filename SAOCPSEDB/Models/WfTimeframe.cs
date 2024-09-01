using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfTimeframe
{
    public int Workflowid { get; set; }

    public int Timeframeno { get; set; }

    public string? Timeframename { get; set; }

    public string? Description { get; set; }

    public string? Responsibilityof { get; set; }

    public int? Initbyworkflow { get; set; }

    public int? Initbyanyevent { get; set; }

    public int? Initbyallevent { get; set; }

    public int? Initbytimeframe { get; set; }

    public int? Perioddays { get; set; }

    public int? Periodweeks { get; set; }

    public int? Periodyears { get; set; }

    public string? Relativeto { get; set; }

    public int? Applycurrentdate { get; set; }

    public int? Applyhistoricaldate { get; set; }

    public int? Satisfyingevent { get; set; }

    public int? Active { get; set; }

    public int? Othertimeframeno { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Businessdays { get; set; }

    public virtual ICollection<WfAction> WfActions { get; set; } = new List<WfAction>();

    public virtual ICollection<WfTfinitevent> WfTfinitevents { get; set; } = new List<WfTfinitevent>();

    public virtual ICollection<WfTfsatisfyingevent> WfTfsatisfyingevents { get; set; } = new List<WfTfsatisfyingevent>();

    public virtual WfWorkflow Workflow { get; set; } = null!;
}
