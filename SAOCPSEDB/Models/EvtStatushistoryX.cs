using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtStatushistoryX
{
    public int Eventid { get; set; }

    public int Historyno { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public int? Changedbyhrid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual HrDatum? Changedbyhr { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual ICollection<EvtPdfX> EvtPdfXes { get; set; } = new List<EvtPdfX>();
}
