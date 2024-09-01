using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class TeamTeamX
{
    public int Teamid { get; set; }

    public string? Teamname { get; set; }

    public string? Claimrole { get; set; }

    public string? Description { get; set; }

    public int? Versionnumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<TeamExclusionsX> TeamExclusionsXes { get; set; } = new List<TeamExclusionsX>();

    public virtual ICollection<TeamInclusionsX> TeamInclusionsXes { get; set; } = new List<TeamInclusionsX>();

    public virtual ICollection<TeamOrgstructX> TeamOrgstructXes { get; set; } = new List<TeamOrgstructX>();

    public virtual ICollection<TeamUsersX> TeamUsersXes { get; set; } = new List<TeamUsersX>();
}
