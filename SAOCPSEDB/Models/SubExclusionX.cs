using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SubExclusionX
{
    public int Exclusionid { get; set; }

    public int? Claimid { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
