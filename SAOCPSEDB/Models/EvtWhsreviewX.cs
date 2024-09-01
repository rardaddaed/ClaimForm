using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtWhsreviewX
{
    public int Eventid { get; set; }

    public DateTime? Reviewdate { get; set; }

    public short? Reviewedriskassessment { get; set; }

    public short? Correctmechanism { get; set; }

    public short? Willactionscontrolhazard { get; set; }

    public short? Furtherinvestigationrequired { get; set; }

    public string? Furtherinvestigationdetails { get; set; }

    public int? Completedbyhrid { get; set; }

    public DateTime? Datecompleted { get; set; }

    public string? Injuryside { get; set; }

    public string? Bodilylocationl1 { get; set; }

    public string? Bodilylocationl2 { get; set; }

    public string? Bodilylocationl3 { get; set; }

    public string? Naturel1 { get; set; }

    public string? Naturel2 { get; set; }

    public string? Mechanisml1 { get; set; }

    public string? Mechanisml2 { get; set; }

    public string? Agencyl1 { get; set; }

    public string? Agencyl2 { get; set; }

    public string? Agencyl3 { get; set; }

    public string? Agencyl4 { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public byte? Reviewfindings { get; set; }

    public byte? Reviewactions { get; set; }

    public virtual HrDatum? Completedbyhr { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;
}
