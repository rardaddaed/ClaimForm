using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class DmsRevision
{
    public int Documentid { get; set; }

    public int Revisionno { get; set; }

    public DateTime? Checkindatetime { get; set; }

    public int? Checkinuser { get; set; }

    public DateTime? Checkoutdatetime { get; set; }

    public string? Filetype { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual DmsRevisionfile? DmsRevisionfile { get; set; }

    public virtual DmsDocument Document { get; set; } = null!;
}
