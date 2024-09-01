using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SchDayofweek
{
    public int Scheduleid { get; set; }

    public int Dayofweekno { get; set; }

    public int? Dayofweek { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SchSchedule Schedule { get; set; } = null!;
}
