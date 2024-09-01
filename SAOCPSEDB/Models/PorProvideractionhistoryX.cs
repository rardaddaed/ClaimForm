using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PorProvideractionhistoryX
{
    public int Providerid { get; set; }

    public int Provideractionhistoryno { get; set; }

    public int? Requestedbyuserid { get; set; }

    public DateTime? Requesteddate { get; set; }

    public string? Requestedcomments { get; set; }

    public int? Actiontype { get; set; }

    public int? Actionbyuserid { get; set; }

    public DateTime? Actiondate { get; set; }

    public string? Actioncomments { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser? Actionbyuser { get; set; }

    public virtual PorProviderX Provider { get; set; } = null!;

    public virtual SecUser? Requestedbyuser { get; set; }
}
