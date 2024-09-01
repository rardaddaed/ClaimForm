using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncnotiIncidentnotificationX
{
    public int Incnotiid { get; set; }

    public string? Shorttitle { get; set; }

    public string? Triggeringevent { get; set; }

    public short? Active { get; set; }

    public short? Sendnotification { get; set; }

    public int? Numberofdays { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public short? Includeincidentreport { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Incidentinvolvesinjury { get; set; }

    public virtual ICollection<IncnotiCorrectiveactiontypeX> IncnotiCorrectiveactiontypeXes { get; set; } = new List<IncnotiCorrectiveactiontypeX>();

    public virtual ICollection<IncnotiIncidentfactorsX> IncnotiIncidentfactorsXes { get; set; } = new List<IncnotiIncidentfactorsX>();

    public virtual ICollection<IncnotiIncidentstatusX> IncnotiIncidentstatusXes { get; set; } = new List<IncnotiIncidentstatusX>();

    public virtual ICollection<IncnotiIncidentsubtypeX> IncnotiIncidentsubtypeXes { get; set; } = new List<IncnotiIncidentsubtypeX>();

    public virtual ICollection<IncnotiIncidenttypeX> IncnotiIncidenttypeXes { get; set; } = new List<IncnotiIncidenttypeX>();

    public virtual ICollection<IncnotiInjurytypeX> IncnotiInjurytypeXes { get; set; } = new List<IncnotiInjurytypeX>();

    public virtual ICollection<IncnotiNotificationemailX> IncnotiNotificationemailXes { get; set; } = new List<IncnotiNotificationemailX>();

    public virtual ICollection<IncnotiNotificationroleX> IncnotiNotificationroleXes { get; set; } = new List<IncnotiNotificationroleX>();

    public virtual ICollection<IncnotiOrganisationalstructureX> IncnotiOrganisationalstructureXes { get; set; } = new List<IncnotiOrganisationalstructureX>();

    public virtual ICollection<IncnotiRiskratingX> IncnotiRiskratingXes { get; set; } = new List<IncnotiRiskratingX>();
}
