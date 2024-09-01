using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncDocumentX
{
    public int Incidentid { get; set; }

    public int Documentno { get; set; }

    public int Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument Document { get; set; } = null!;

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
