using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtInvestigationreviewX
{
    public int Eventid { get; set; }

    public int Reviewno { get; set; }

    public DateTime? Datereviewed { get; set; }

    public int? Reviewedbyhrid { get; set; }

    public short? Reviewedsecurityrating { get; set; }

    public string? Investigationreviewdropdown { get; set; }

    public string? Detailsofcorrectiveactions { get; set; }

    public string? Endorsement { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public byte? Reviewfindings { get; set; }

    public byte? Reviewactions { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual HrDatum? Reviewedbyhr { get; set; }
}
