using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtPdfX
{
    public int Geventid { get; set; }

    public int Pdfno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Datetimegenerated { get; set; }

    public int? Statushistoryno { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual GevtEventX Gevent { get; set; } = null!;
}
