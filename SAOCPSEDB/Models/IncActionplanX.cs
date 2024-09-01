using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncActionplanX
{
    public int Incidentid { get; set; }

    public string? Consequence { get; set; }

    public string? Likelihood { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public short? Noaction { get; set; }

    public string? Actiondetails { get; set; }

    public virtual ICollection<IncActionlevelX> IncActionlevelXes { get; set; } = new List<IncActionlevelX>();

    public virtual ICollection<IncCorrectiveactionX> IncCorrectiveactionXes { get; set; } = new List<IncCorrectiveactionX>();

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
