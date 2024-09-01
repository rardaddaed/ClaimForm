using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncDetailsX
{
    public int Incidentid { get; set; }

    public DateTime? Dateofincident { get; set; }

    public DateTime? Timeofincident { get; set; }

    public DateTime? Dateadvised { get; set; }

    public DateTime? Timeadvised { get; set; }

    public int? Isrepeat { get; set; }

    public int? Isrecurrence { get; set; }

    public int? Reportedtopartyid { get; set; }

    public string? Location { get; set; }

    public string? Specificarea { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? Noknownsuburb { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
