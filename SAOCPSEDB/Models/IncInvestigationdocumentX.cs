using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncInvestigationdocumentX
{
    public int Incidentid { get; set; }

    public int Docno { get; set; }

    public int? Documentid { get; set; }

    public string? Description { get; set; }

    public short Isreportform { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
