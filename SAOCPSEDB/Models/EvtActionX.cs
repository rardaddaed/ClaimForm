using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtActionX
{
    public int Eventid { get; set; }

    public int Actionno { get; set; }

    public string? Actiontitle { get; set; }

    public string? Controltype { get; set; }

    public string? Actiondescription { get; set; }

    public int? Actionpersonresponsiblehrid { get; set; }

    public DateTime? Targetcompletiondate { get; set; }

    public int? Actionenteredbyhrid { get; set; }

    public DateTime? Actiondateentered { get; set; }

    public string? Completionstatus { get; set; }

    public short? Percentagecomplete { get; set; }

    public DateTime? Actualcompletiondate { get; set; }

    public string? Actioncompletedescription { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Compldetailsenteredbyhrid { get; set; }

    public DateTime? Compldetailsdateentered { get; set; }

    public virtual HrDatum? Actionenteredbyhr { get; set; }

    public virtual HrDatum? Actionpersonresponsiblehr { get; set; }

    public virtual HrDatum? Compldetailsenteredbyhr { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;
}
