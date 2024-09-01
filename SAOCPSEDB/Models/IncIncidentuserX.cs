using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncIncidentuserX
{
    public int Incidentuserid { get; set; }

    public int? Partyid { get; set; }

    public int? Userid { get; set; }

    public string? Username { get; set; }

    public byte[]? Password { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ParParty? Party { get; set; }

    public virtual SecUser? User { get; set; }
}
