using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncInvestigationreasonX
{
    public int Incidentid { get; set; }

    public int Reasonno { get; set; }

    public string? Reason { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncInvestigationX Incident { get; set; } = null!;
}
