using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParNumber
{
    public int Partyid { get; set; }

    public int Numberno { get; set; }

    public string? Numbertype { get; set; }

    public string? Number { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ParParty Party { get; set; } = null!;
}
