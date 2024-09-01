using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PorUserpositionX
{
    public int Userid { get; set; }

    public int Userpositionno { get; set; }

    public int? Positionid { get; set; }

    public DateTime? Positionstartdate { get; set; }

    public DateTime? Positionenddate { get; set; }

    public int? Positionongoing { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Simspositionno { get; set; }

    public virtual SecPosition? Position { get; set; }

    public virtual PorUserX User { get; set; } = null!;
}
