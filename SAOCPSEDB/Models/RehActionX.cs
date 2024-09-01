using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RehActionX
{
    public int Rehabid { get; set; }

    public int Rehabactionno { get; set; }

    public string? Actionsservices { get; set; }

    public string? Personresponsible { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual RehRehab Rehab { get; set; } = null!;
}
