using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfEvent
{
    public int Eventid { get; set; }

    public string? Eventtype { get; set; }

    public decimal? Quantity { get; set; }

    public string? Chronology { get; set; }

    public string? Eventname { get; set; }

    public string? Description { get; set; }

    public int? Active { get; set; }

    public int? Terminatingevent { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<WfEventCode> WfEventCodes { get; set; } = new List<WfEventCode>();

    public virtual WfEventCriterion? WfEventCriterion { get; set; }

    public virtual ICollection<WfEventOrgstructX> WfEventOrgstructXes { get; set; } = new List<WfEventOrgstructX>();
}
