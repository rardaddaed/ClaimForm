using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmClaimtask
{
    public int Claimid { get; set; }

    public int Taskno { get; set; }

    public string? Tasktype { get; set; }

    public string? Task { get; set; }

    public int? Personresp { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? Reminderdate { get; set; }

    public DateTime? Datecompleted { get; set; }

    public string? Note { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public int? Enteredbyuserid { get; set; }

    public DateTime? Dateentered { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmClaimtaskdocument> ClmClaimtaskdocuments { get; set; } = new List<ClmClaimtaskdocument>();

    public virtual SecUser? Enteredbyuser { get; set; }
}
