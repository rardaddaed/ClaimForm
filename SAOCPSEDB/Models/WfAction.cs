using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfAction
{
    public int Workflowid { get; set; }

    public int Timeframeno { get; set; }

    public int Actionno { get; set; }

    public string? Performwhen { get; set; }

    public string? Actiontype { get; set; }

    public int? Actionchronology { get; set; }

    public int? Days { get; set; }

    public int? Recurring { get; set; }

    public int? Recurringdays { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WfActionDetail? WfActionDetail { get; set; }

    public virtual ICollection<WfActionposition> WfActionpositions { get; set; } = new List<WfActionposition>();

    public virtual ICollection<WfActionrole> WfActionroles { get; set; } = new List<WfActionrole>();

    public virtual WfTimeframe WfTimeframe { get; set; } = null!;

    public virtual WfWorkflow Workflow { get; set; } = null!;
}
