using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncStatushistoryX
{
    public int Incidentid { get; set; }

    public int Statusno { get; set; }

    public string? Status { get; set; }

    public DateTime? Datestatuschanged { get; set; }

    public int? Changedbyinchrid { get; set; }

    public int? Changedbyuserid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncHrdataX? Changedbyinchr { get; set; }

    public virtual SecUser? Changedbyuser { get; set; }

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
