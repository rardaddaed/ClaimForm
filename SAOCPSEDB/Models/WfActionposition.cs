using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfActionposition
{
    public int Workflowid { get; set; }

    public int Timeframeno { get; set; }

    public int Actionno { get; set; }

    public int Positionno { get; set; }

    public int? Positionid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecPosition? Position { get; set; }

    public virtual WfAction WfAction { get; set; } = null!;
}
