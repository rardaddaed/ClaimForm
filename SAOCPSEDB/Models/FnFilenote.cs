using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class FnFilenote
{
    public int Filenoteid { get; set; }

    public string? Categorycodetype { get; set; }

    public string? Category { get; set; }

    public string? Subject { get; set; }

    public string? Note { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? Reminderdate { get; set; }

    public DateTime? Datecompleted { get; set; }

    public int? Enteredbyuserid { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Timeentered { get; set; }

    public int? Confidential { get; set; }

    public int? Assignaction { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmFilenote> ClmFilenotes { get; set; } = new List<ClmFilenote>();

    public virtual ICollection<ClmRehabnote> ClmRehabnotes { get; set; } = new List<ClmRehabnote>();

    public virtual SecUser? Enteredbyuser { get; set; }

    public virtual ICollection<FnDocument> FnDocuments { get; set; } = new List<FnDocument>();

    public virtual ICollection<FnResponsibility> FnResponsibilities { get; set; } = new List<FnResponsibility>();
}
