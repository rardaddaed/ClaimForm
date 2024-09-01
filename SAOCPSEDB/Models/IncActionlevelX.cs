using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncActionlevelX
{
    public int Incidentid { get; set; }

    public int Controllevelno { get; set; }

    public string? Controllevel { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<IncActionleveltypeX> IncActionleveltypeXes { get; set; } = new List<IncActionleveltypeX>();

    public virtual IncActionplanX Incident { get; set; } = null!;
}
