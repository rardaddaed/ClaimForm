using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecUserXBak
{
    public int Userid { get; set; }

    public int? Requestedbyuserid { get; set; }

    public DateTime? Requesteddate { get; set; }

    public string? Requestedcomments { get; set; }

    public int? Approveddbyuserid { get; set; }

    public DateTime? Datemanagerapproved { get; set; }

    public string? Managerapprovalcomments { get; set; }

    public int? Termsandconditionsaccepted { get; set; }

    public DateTime? Datetermsandconditionsaccepted { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public int? Summaryscreen { get; set; }

    public int? Portfolio { get; set; }

    public int? Remoteaccessenabled { get; set; }

    public string? Remoteaccessmobile { get; set; }
}
