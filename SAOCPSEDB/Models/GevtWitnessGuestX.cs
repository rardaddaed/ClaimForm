using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtWitnessGuestX
{
    public int Geventid { get; set; }

    public int Witnessno { get; set; }

    public string? Employeeid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtWitnessX GevtWitnessX { get; set; } = null!;
}
