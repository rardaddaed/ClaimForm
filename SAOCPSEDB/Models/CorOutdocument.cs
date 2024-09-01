using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class CorOutdocument
{
    public int Correspondenceoutid { get; set; }

    public int Outdocumentno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Sentto { get; set; }

    public virtual CorCorrespondenceout Correspondenceout { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }
}
