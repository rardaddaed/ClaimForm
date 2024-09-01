using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParProvidernumber
{
    public int Partyid { get; set; }

    public int Providernumberno { get; set; }

    public string? Providernumbertype { get; set; }

    public string? Providernumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ParProvider Party { get; set; } = null!;
}
