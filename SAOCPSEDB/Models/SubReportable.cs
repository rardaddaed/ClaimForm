using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SubReportable
{
    public int Reportableid { get; set; }

    public string? Reportabletype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmClaimSa> ClmClaimSas { get; set; } = new List<ClmClaimSa>();

    public virtual ICollection<SubReportabledate> SubReportabledates { get; set; } = new List<SubReportabledate>();
}
