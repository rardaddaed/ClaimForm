using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SubSubmissionSa
{
    public int Submissionid { get; set; }

    public int? Licenceid { get; set; }

    public int? Firstbatchidused { get; set; }

    public int? Lastbatchidused { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SubSubmission Submission { get; set; } = null!;
}
