using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncFactorindividualX
{
    public int Incidentid { get; set; }

    public int Factorno { get; set; }

    public string? Factor { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncInvestigationpartbX Incident { get; set; } = null!;
}
