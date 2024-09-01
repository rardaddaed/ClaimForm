using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RptDocumentX
{
    public int Reportid { get; set; }

    public int Documentno { get; set; }

    public string? Serversavefilepath { get; set; }

    public byte[]? Timestamp { get; set; }

    public Guid Guid { get; set; }

    public virtual RptDocument RptDocument { get; set; } = null!;
}
