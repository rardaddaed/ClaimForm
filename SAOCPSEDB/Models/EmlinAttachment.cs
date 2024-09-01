using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EmlinAttachment
{
    public int Emailid { get; set; }

    public int Attachno { get; set; }

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

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Filenotecategory { get; set; }

    public string? Rehabfilenotecategory { get; set; }

    public string? Receivedfrom { get; set; }

    public DateTime? Documentdate { get; set; }

    public int? Confidential { get; set; }

    public int? Personresponsibleuserid { get; set; }

    public DateTime? Dateassigned { get; set; }

    public int? Processedbyuserid { get; set; }

    public string? Docstatus { get; set; }

    public DateTime? Docstatusdate { get; set; }

    public string? Docstatusreason { get; set; }

    public string? Notes { get; set; }

    public virtual DmsDocument? Document { get; set; }

    public virtual EmlinEmail Email { get; set; } = null!;

    public virtual ICollection<EmlinAttachmentpersonresponsiblehistory> EmlinAttachmentpersonresponsiblehistories { get; set; } = new List<EmlinAttachmentpersonresponsiblehistory>();

    public virtual ICollection<EmlinAttachmentstatushistory> EmlinAttachmentstatushistories { get; set; } = new List<EmlinAttachmentstatushistory>();

    public virtual EmlinMedcert? EmlinMedcert { get; set; }

    public virtual EmlinRehab? EmlinRehab { get; set; }

    public virtual SecUser? Personresponsibleuser { get; set; }

    public virtual SecUser? Processedbyuser { get; set; }
}
