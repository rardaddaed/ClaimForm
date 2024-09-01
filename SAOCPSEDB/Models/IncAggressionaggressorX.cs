using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncAggressionaggressorX
{
    public int Incidentid { get; set; }

    public int Aggressorno { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public int? Age { get; set; }

    public string? Relationship { get; set; }

    public int? Causedprevious { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncAggressiondetailsX Incident { get; set; } = null!;
}
