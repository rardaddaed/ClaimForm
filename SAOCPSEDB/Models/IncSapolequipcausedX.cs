using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncSapolequipcausedX
{
    public int Incidentid { get; set; }

    public int Equipmentno { get; set; }

    public string? Equipment { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncSapolX Incident { get; set; } = null!;
}
