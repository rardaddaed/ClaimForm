using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecUserEventtypeX
{
    public int Userid { get; set; }

    public short? Incident { get; set; }

    public short? InjuryIllness { get; set; }

    public short? Hazard { get; set; }

    public short? ClientIncident { get; set; }

    public short? Feedback { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser User { get; set; } = null!;
}
