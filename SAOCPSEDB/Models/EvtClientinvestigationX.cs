using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtClientinvestigationX
{
    public int Eventid { get; set; }

    public int? Assessmentcompletedbyhrid { get; set; }

    public DateTime? Assessmentdate { get; set; }

    public short? Requirefullinvestigation { get; set; }

    public string? Assessmentnotes { get; set; }

    public short? Referredtoexternalbody { get; set; }

    public string? Agencyreferredto { get; set; }

    public DateTime? Datereferred { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual HrDatum? Assessmentcompletedbyhr { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;
}
