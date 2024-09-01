using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtFindingX
{
    public int Eventid { get; set; }

    public int Findingno { get; set; }

    public string? Investigationfinding { get; set; }

    public int? Stepstopreventrecurrence { get; set; }

    public int? Findingenteredbyhrid { get; set; }

    public DateTime? Dateenteredfinding { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Whynorecurrencesteps { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual HrDatum? Findingenteredbyhr { get; set; }
}
