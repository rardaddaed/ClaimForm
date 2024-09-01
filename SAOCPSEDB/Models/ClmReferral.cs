using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmReferral
{
    public int Claimid { get; set; }

    public int Referralno { get; set; }

    public DateTime? Dateentered { get; set; }

    public string? Referraltypecodevalue { get; set; }

    public string? Venue { get; set; }

    public DateTime? Dateofappointment { get; set; }

    public DateTime? Timeofappointment { get; set; }

    public int? Providerpartyid { get; set; }

    public int? Failedtoattend { get; set; }

    public string? Reasonfailedtoattend { get; set; }

    public string? Comments { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ParParty? Providerparty { get; set; }
}
