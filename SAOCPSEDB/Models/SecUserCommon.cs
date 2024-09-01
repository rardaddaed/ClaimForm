using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecUserCommon
{
    public int Userid { get; set; }

    public int? Supervisoruserid { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Datemodified { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Signature { get; set; }

    public virtual DmsDocument? Document { get; set; }

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual SecUser? ModifiedbyNavigation { get; set; }

    public virtual SecUser? Supervisoruser { get; set; }

    public virtual SecUser User { get; set; } = null!;
}
