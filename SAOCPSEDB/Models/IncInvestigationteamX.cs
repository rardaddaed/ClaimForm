using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncInvestigationteamX
{
    public int Incidentid { get; set; }

    public int Teamno { get; set; }

    public int? Inchrid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncInvestigationX Incident { get; set; } = null!;
}
