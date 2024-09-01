using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecUserposition
{
    public int Userid { get; set; }

    public int Positionno { get; set; }

    public int? Positionid { get; set; }

    public DateTime? Positionstart { get; set; }

    public DateTime? Positionend { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecPosition? Position { get; set; }

    public virtual SecUserpositionClaim? SecUserpositionClaim { get; set; }

    public virtual SecUserpositionCommon? SecUserpositionCommon { get; set; }

    public virtual SecUser User { get; set; } = null!;
}
