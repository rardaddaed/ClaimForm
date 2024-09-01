using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecPositionprofile
{
    public int Positionid { get; set; }

    public string Profile { get; set; } = null!;

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecPosition Position { get; set; } = null!;
}
