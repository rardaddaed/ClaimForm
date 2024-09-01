using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfTfsatisfyingevent
{
    public int Workflowid { get; set; }

    public int Timeframeno { get; set; }

    public int Statisfyingeventno { get; set; }

    public int? Eventid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WfTimeframe WfTimeframe { get; set; } = null!;

    public virtual WfWorkflow Workflow { get; set; } = null!;
}
