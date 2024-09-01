using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncReviewX
{
    public int Incidentid { get; set; }

    public int? Confirminjurycoding { get; set; }

    public int? Confirmcostcentre { get; set; }

    public string? Comments { get; set; }

    public DateTime? Closeddate { get; set; }

    public string? Closurecomments { get; set; }

    public int? Reviewedbyuserid { get; set; }

    public int? Reviewedbyid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<IncReviewsummaryX> IncReviewsummaryXes { get; set; } = new List<IncReviewsummaryX>();

    public virtual IncIncidentX1 Incident { get; set; } = null!;

    public virtual IncHrdataX? Reviewedby { get; set; }

    public virtual SecUser? Reviewedbyuser { get; set; }
}
