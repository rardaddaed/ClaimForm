using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRtwassessmentX
{
    public int Claimid { get; set; }

    public int Rtwassessmentno { get; set; }

    public string? Assessmenttype { get; set; }

    public string? Assessmentstatus { get; set; }

    public int? Rtwconsultant { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Completiondate { get; set; }

    public string? Assessmentoutcome { get; set; }

    public string? Comments { get; set; }

    public int? Documentid { get; set; }

    public int? Rtwproviderid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual SecUser? RtwconsultantNavigation { get; set; }

    public virtual ParParty? Rtwprovider { get; set; }
}
