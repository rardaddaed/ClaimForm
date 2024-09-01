using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmRate
{
    public int Rateid { get; set; }

    public string? Ratetype { get; set; }

    public int? Jurisdictionzone { get; set; }

    public DateTime? Dateeffectivefrom { get; set; }

    public DateTime? Dateeffectiveto { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
