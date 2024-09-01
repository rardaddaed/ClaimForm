using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class DmsRevisionfile
{
    public int Documentid { get; set; }

    public int Revisionno { get; set; }

    public byte[]? Document { get; set; }

    public byte[]? Timestamp { get; set; }

    public Guid Guid { get; set; }

    public int Fulltextid { get; set; }

    public string? Filetype { get; set; }

    public string? Documenttext { get; set; }

    public Guid? Documentguid { get; set; }

    public string? Documentprovider { get; set; }

    public string? Documentkey { get; set; }

    public virtual DmsRevision DmsRevision { get; set; } = null!;
}
