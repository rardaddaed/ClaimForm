using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmPorpositionX
{
    public int Porpositionid { get; set; }

    public int? Positionid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecPosition? Position { get; set; }
}
