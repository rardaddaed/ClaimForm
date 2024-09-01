using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtNotificationcontactX
{
    public int Geventid { get; set; }

    public int Notificationno { get; set; }

    public int? Hrid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtEventX Gevent { get; set; } = null!;
}
