using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfInitiatingevent
{
    public int Workflowid { get; set; }

    public int Initiatingeventno { get; set; }

    public int? Eventid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WfWorkflow Workflow { get; set; } = null!;
}
