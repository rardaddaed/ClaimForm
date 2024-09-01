using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncReviewsummaryX
{
    public int Incidentid { get; set; }

    public int Reviewno { get; set; }

    public int? Reviewedbyuserid { get; set; }

    public int? Reviewedbyid { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Reviewdatetime { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Reviewername { get; set; }

    public virtual DmsDocument? Document { get; set; }

    public virtual IncReviewX Incident { get; set; } = null!;

    public virtual IncHrdataX? Reviewedby { get; set; }

    public virtual SecUser? Reviewedbyuser { get; set; }
}
