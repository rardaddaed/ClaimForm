using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class TeamOrgstructX
{
    public int Teamid { get; set; }

    public int Teamorgstructno { get; set; }

    public int? Orgstructid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual OsOrgstructure? Orgstruct { get; set; }

    public virtual TeamTeamX Team { get; set; } = null!;
}
