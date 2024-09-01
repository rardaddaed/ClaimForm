using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncSecuritycontroltypeX
{
    public int Incidentid { get; set; }

    public int Controlno { get; set; }

    public string? Controltype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
