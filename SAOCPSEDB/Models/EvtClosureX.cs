using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtClosureX
{
    public int Eventid { get; set; }

    public DateTime? Dateeventclosed { get; set; }

    public int? Closedbyhrid { get; set; }

    public string? Closurecomments { get; set; }

    public int? Reopenedbyhrid { get; set; }

    public DateTime? Datereopened { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual HrDatum? Closedbyhr { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual HrDatum? Reopenedbyhr { get; set; }
}
