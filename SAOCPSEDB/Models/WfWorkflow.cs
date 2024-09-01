using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfWorkflow
{
    public int Workflowid { get; set; }

    public string? Entitytype { get; set; }

    public string? Workflowname { get; set; }

    public string? Description { get; set; }

    public int? Active { get; set; }

    public int? Initiatingevent { get; set; }

    public int? Terminatingevent { get; set; }

    public int? Escalate { get; set; }

    public int? Other { get; set; }

    public int? Otherid { get; set; }

    public int? Daysoverdue { get; set; }

    public int? Weeksoverdue { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<WfAction> WfActions { get; set; } = new List<WfAction>();

    public virtual ICollection<WfEscalatetoteam> WfEscalatetoteams { get; set; } = new List<WfEscalatetoteam>();

    public virtual ICollection<WfInitiatingevent> WfInitiatingevents { get; set; } = new List<WfInitiatingevent>();

    public virtual ICollection<WfTerminatingevent> WfTerminatingevents { get; set; } = new List<WfTerminatingevent>();

    public virtual ICollection<WfTfinitevent> WfTfinitevents { get; set; } = new List<WfTfinitevent>();

    public virtual ICollection<WfTfsatisfyingevent> WfTfsatisfyingevents { get; set; } = new List<WfTfsatisfyingevent>();

    public virtual ICollection<WfTimeframe> WfTimeframes { get; set; } = new List<WfTimeframe>();

    public virtual ICollection<WfxWorkflow> WfxWorkflows { get; set; } = new List<WfxWorkflow>();
}
