using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class FnResponsibility
{
    public int Filenoteid { get; set; }

    public int Responsibilityno { get; set; }

    public string? Responsibilitytype { get; set; }

    public int? Responsibilityofuserid { get; set; }

    public string? Responsibilityofotheremail { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual FnFilenote Filenote { get; set; } = null!;

    public virtual SecUser? Responsibilityofuser { get; set; }
}
