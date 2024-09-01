using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfEscalatetoteam
{
    public int Workflowid { get; set; }

    public int Escalatetono { get; set; }

    public string? Teamrole { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WfWorkflow Workflow { get; set; } = null!;
}
