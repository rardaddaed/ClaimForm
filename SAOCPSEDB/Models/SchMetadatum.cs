using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SchMetadatum
{
    public int Metadataid { get; set; }

    public DateTime? Schedulerrundatetime { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
