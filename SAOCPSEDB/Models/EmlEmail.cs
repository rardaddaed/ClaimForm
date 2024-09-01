using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EmlEmail
{
    public int Emailid { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Datesent { get; set; }

    public string? Subject { get; set; }

    public string? Msgbody { get; set; }

    public string? Status { get; set; }

    public int? Enteredby { get; set; }

    public int? Sentby { get; set; }

    public string? Batchid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public int? Bccsender { get; set; }

    public string? Securityclassification { get; set; }

    public string? Dlm { get; set; }

    public short? Confidential { get; set; }

    public DateTime? Timesent { get; set; }

    public int? Includeemailsignature { get; set; }

    public virtual ICollection<ClmEmail> ClmEmails { get; set; } = new List<ClmEmail>();

    public virtual ICollection<EmlAddress> EmlAddresses { get; set; } = new List<EmlAddress>();

    public virtual ICollection<EmlAttachment> EmlAttachments { get; set; } = new List<EmlAttachment>();

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual SecUser? SentbyNavigation { get; set; }
}
