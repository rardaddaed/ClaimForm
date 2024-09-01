using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EmlAttachment
{
    public int Emailid { get; set; }

    public int Emailattachno { get; set; }

    public int? Documentid { get; set; }

    public string? Status { get; set; }

    public int? Rejected { get; set; }

    public DateTime? Rejecteddate { get; set; }

    public int? Processed { get; set; }

    public DateTime? Processeddate { get; set; }

    public string? Destination { get; set; }

    public string? Documenttype { get; set; }

    public string? Category { get; set; }

    public string? Description { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Attachmentsource { get; set; }

    public virtual DmsDocument? Document { get; set; }

    public virtual EmlEmail Email { get; set; } = null!;
}
