using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EmlinEmail
{
    public int Emailid { get; set; }

    public DateTime? Dateentered { get; set; }

    public string? Batchid { get; set; }

    public string? Emailfrom { get; set; }

    public string? Emailto { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<EmlinAttachment> EmlinAttachments { get; set; } = new List<EmlinAttachment>();

    public virtual ICollection<EmlinCorrin> EmlinCorrins { get; set; } = new List<EmlinCorrin>();

    public virtual ICollection<EmlinCorrout> EmlinCorrouts { get; set; } = new List<EmlinCorrout>();

    public virtual ICollection<EmlinFilenote> EmlinFilenotes { get; set; } = new List<EmlinFilenote>();

    public virtual ICollection<EmlinPayment> EmlinPayments { get; set; } = new List<EmlinPayment>();

    public virtual ICollection<EmlinProviderdocument> EmlinProviderdocuments { get; set; } = new List<EmlinProviderdocument>();
}
