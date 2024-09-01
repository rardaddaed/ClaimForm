using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParEmployeeX
{
    public int Partyid { get; set; }

    public string? Superannuationnumber { get; set; }

    public string? Claimprefix { get; set; }

    public int? Lastclaimsuffix { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ParEmployee Party { get; set; } = null!;
}
