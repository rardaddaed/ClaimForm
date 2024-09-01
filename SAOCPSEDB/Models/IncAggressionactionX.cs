using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncAggressionactionX
{
    public int Incidentid { get; set; }

    public int Actionno { get; set; }

    public string? Action { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncAggressiondetailsX Incident { get; set; } = null!;
}
