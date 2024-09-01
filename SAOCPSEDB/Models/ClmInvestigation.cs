using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmInvestigation
{
    public int Claimid { get; set; }

    public int Investigationno { get; set; }

    public string? Investigation { get; set; }

    public int? Investigatorpartyid { get; set; }

    public int? Confidential { get; set; }

    public DateTime? Datereferred { get; set; }

    public DateTime? Appointmentdate { get; set; }

    public decimal? Approvedhours { get; set; }

    public DateTime? Datetobecompleted { get; set; }

    public DateTime? Reportduedate { get; set; }

    public int? Reportcompleted { get; set; }

    public DateTime? Reportcompleteddate { get; set; }

    public int? Documentid { get; set; }

    public string? Comments { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual ParParty? Investigatorparty { get; set; }
}
