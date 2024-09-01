using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncAggressionfactorsX
{
    public int Incidentid { get; set; }

    public int Factorno { get; set; }

    public string? Factortype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncAggressiondetailsX Incident { get; set; } = null!;
}
