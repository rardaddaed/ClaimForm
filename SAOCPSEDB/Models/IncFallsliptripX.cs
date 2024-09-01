using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncFallsliptripX
{
    public int Incidentid { get; set; }

    public int? Occurredtolowerlevel { get; set; }

    public string? Falloccurredfrom { get; set; }

    public string? Falloccurredother { get; set; }

    public int? Involvedobjectorhazard { get; set; }

    public string? Objectinvolved { get; set; }

    public string? Objectinvolvedother { get; set; }

    public string? Falloccurredlocation { get; set; }

    public string? Falloccurredlocationother { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
