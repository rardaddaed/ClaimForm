using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncActionleveltypeX
{
    public int Incidentid { get; set; }

    public int Controllevelno { get; set; }

    public int Controlno { get; set; }

    public string? Controltype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual IncActionlevelX IncActionlevelX { get; set; } = null!;
}
