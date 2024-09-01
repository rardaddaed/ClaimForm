using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtNotificationhistoryX
{
    public int Eventid { get; set; }

    public int Notificationhistoryno { get; set; }

    public string? Triggeringevent { get; set; }

    public DateTime? Notificationdatetime { get; set; }

    public string? Recipients { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
