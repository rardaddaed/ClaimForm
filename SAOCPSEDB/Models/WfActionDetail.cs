using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfActionDetail
{
    public int Workflowid { get; set; }

    public int Timeframeno { get; set; }

    public int Actionno { get; set; }

    public string? Emailbody { get; set; }

    public string? Alerttext { get; set; }

    public string? Smstext { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WfAction WfAction { get; set; } = null!;
}
