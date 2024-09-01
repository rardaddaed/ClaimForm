using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtDocumentX
{
    public int Geventid { get; set; }

    public int Docno { get; set; }

    public int? Documentid { get; set; }

    public short? Confidential { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual GevtEventX Gevent { get; set; } = null!;
}
