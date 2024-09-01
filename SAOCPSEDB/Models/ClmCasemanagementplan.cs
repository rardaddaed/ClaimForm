using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmCasemanagementplan
{
    public int Claimid { get; set; }

    public int Casemanagementplanno { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredbyuserid { get; set; }

    public DateTime? Reviewdate { get; set; }

    public int? Reviewedbyuserid { get; set; }

    public int? Confidential { get; set; }

    public int? Weekssinceinjury { get; set; }

    public string? Reviewtype { get; set; }

    public DateTime? Nextreviewdate { get; set; }

    public string? Capacity { get; set; }

    public DateTime? Capacitydatefrom { get; set; }

    public DateTime? Capacitydateto { get; set; }

    public decimal? Grosspaid { get; set; }

    public decimal? Recovered { get; set; }

    public decimal? Netpaid { get; set; }

    public int? Lastweekofpayment { get; set; }

    public decimal? Grossoutstanding { get; set; }

    public decimal? Outstandingrecoveries { get; set; }

    public decimal? Netoutstanding { get; set; }

    public int? Dayslost { get; set; }

    public decimal? Grossincured { get; set; }

    public decimal? Totalrecoveries { get; set; }

    public decimal? Netincured { get; set; }

    public int? Hourslost { get; set; }

    public string? Currentstatusstrategy { get; set; }

    public string? Actions { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Plandocumentid { get; set; }

    public string? Claimclassification { get; set; }

    public DateTime? Workerdateofbirth { get; set; }

    public string? Mechanism2codetype { get; set; }

    public string? Mechanism2 { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmCasemanagementplanbarrier> ClmCasemanagementplanbarriers { get; set; } = new List<ClmCasemanagementplanbarrier>();

    public virtual ICollection<ClmCasemanagementplandoc> ClmCasemanagementplandocs { get; set; } = new List<ClmCasemanagementplandoc>();

    public virtual SecUser? Reviewedbyuser { get; set; }
}
