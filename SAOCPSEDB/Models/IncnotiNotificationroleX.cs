﻿using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncnotiNotificationroleX
{
    public int Incnotiid { get; set; }

    public int Roleno { get; set; }

    public string? Role { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncnotiIncidentnotificationX Incnoti { get; set; } = null!;
}
