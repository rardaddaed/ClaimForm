using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfActionrole
{
    public int Workflowid { get; set; }

    public int Timeframeno { get; set; }

    public int Actionno { get; set; }

    public int Roleno { get; set; }

    public string? Role { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WfAction WfAction { get; set; } = null!;
}
