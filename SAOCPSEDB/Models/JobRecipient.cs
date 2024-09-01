using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class JobRecipient
{
    public int Jobid { get; set; }

    public int Recipientno { get; set; }

    public string? Recipienttype { get; set; }

    public int? Recipientuserid { get; set; }

    public string? Otherrecipientemail { get; set; }

    public string? Securitytype { get; set; }

    public string? Deliverymethod { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Active { get; set; }

    public virtual JobJob Job { get; set; } = null!;

    public virtual ICollection<RptDocument> RptDocuments { get; set; } = new List<RptDocument>();
}
