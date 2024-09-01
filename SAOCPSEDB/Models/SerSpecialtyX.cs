using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerSpecialtyX
{
    public int Servicespecialtyid { get; set; }

    public string? Source { get; set; }

    public string? Item { get; set; }

    public string? Specialty { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
