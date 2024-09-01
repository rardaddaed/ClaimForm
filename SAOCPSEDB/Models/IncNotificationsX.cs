using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncNotificationsX
{
    public int Incidentid { get; set; }

    public int Notificationno { get; set; }

    public string? Role { get; set; }

    public int? Inchrid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Userid { get; set; }

    public virtual IncHrdataX? Inchr { get; set; }

    public virtual IncIncidentX1 Incident { get; set; } = null!;

    public virtual SecUser? User { get; set; }
}
