using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PolPolicy
{
    public int Policyid { get; set; }

    public int? Active { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Policytype { get; set; }

    public string? Insurer { get; set; }

    public string? Insurernumber { get; set; }

    public int? Jurisdictionzone { get; set; }

    public string? Policynumber { get; set; }

    public string? Workcoveremployernumber { get; set; }

    public string? Brokerid { get; set; }

    public string? Teamnumber { get; set; }

    public int? Injurymanagementprogram { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Policyname { get; set; }

    public virtual ICollection<LegPolicy> LegPolicies { get; set; } = new List<LegPolicy>();

    public virtual ICollection<PolCoverage> PolCoverages { get; set; } = new List<PolCoverage>();
}
