using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncdocFilequeueX
{
    public int Incdocid { get; set; }

    public DateTime? Datereceived { get; set; }

    public string? Subject { get; set; }

    public string? Sender { get; set; }

    public string? Reason { get; set; }

    public string? Filename { get; set; }

    public int? Documentid { get; set; }

    public short? Reject { get; set; }

    public short? Removed { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual DmsDocument? Document { get; set; }
}
