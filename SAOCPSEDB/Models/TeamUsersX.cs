using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class TeamUsersX
{
    public int Teamid { get; set; }

    public int Teamuserno { get; set; }

    public int? Userid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual TeamTeamX Team { get; set; } = null!;

    public virtual SecUser? User { get; set; }
}
