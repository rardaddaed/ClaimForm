using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SubSubmission
{
    public int Submissionid { get; set; }

    public int? Jurisdictionzone { get; set; }

    public string? Submissiontype { get; set; }

    public DateTime? Generatedondate { get; set; }

    public int? Generatedbyuserid { get; set; }

    public DateTime? Submissionperiodfrom { get; set; }

    public DateTime? Submissionperiodto { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<SubDocument> SubDocuments { get; set; } = new List<SubDocument>();

    public virtual SubSubmissionSa? SubSubmissionSa { get; set; }
}
