using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtPdfX
{
    public int Eventid { get; set; }

    public int Pdfno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Datetimegenerated { get; set; }

    public int? Statushistoryno { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual EvtStatushistoryX? EvtStatushistoryX { get; set; }
}
