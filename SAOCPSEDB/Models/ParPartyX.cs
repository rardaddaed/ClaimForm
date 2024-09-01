using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParPartyX
{
    public int Partyid { get; set; }

    public string? Eftname { get; set; }

    public string? Masterpiecevendortype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ParParty Party { get; set; } = null!;
}
