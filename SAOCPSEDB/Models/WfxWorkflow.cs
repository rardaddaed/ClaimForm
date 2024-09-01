using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfxWorkflow
{
    public int Wfxworkflowid { get; set; }

    public string? Entitytype { get; set; }

    public int? Entityid { get; set; }

    public DateTime? Datetriggered { get; set; }

    public int? Active { get; set; }

    public int? Workflowid { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<WfxTimeframe> WfxTimeframes { get; set; } = new List<WfxTimeframe>();

    public virtual WfWorkflow? Workflow { get; set; }
}
