using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncHrloadAgencyruleX
{
    public int Agencyruleid { get; set; }

    public string? Portfolio { get; set; }

    public string? Region { get; set; }

    public string? Agency { get; set; }

    public short? Leadingzero { get; set; }

    public int? Numdigits { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
