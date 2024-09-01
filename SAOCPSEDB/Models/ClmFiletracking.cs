using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmFiletracking
{
    public int Claimid { get; set; }

    public int Filetrackingno { get; set; }

    public int? Numberoffiles { get; set; }

    public string? Archiverefboxnumber { get; set; }

    public string? Trackedfrom { get; set; }

    public string? Trackedto { get; set; }

    public DateTime? Datesent { get; set; }

    public DateTime? Datereceivedorreturned { get; set; }

    public string? Comments { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual SecUser? EnteredbyNavigation { get; set; }
}
