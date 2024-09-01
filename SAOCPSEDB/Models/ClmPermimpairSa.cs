using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPermimpairSa
{
    public int Claimid { get; set; }

    public int Saimpairmentno { get; set; }

    public DateTime? Assessmentdate { get; set; }

    public string? Assessmenttype { get; set; }

    public string? Injurytype { get; set; }

    public decimal? Impairmentpercentage { get; set; }

    public string? Examination { get; set; }

    public string? Diagnosis { get; set; }

    public int? Assessmentproviderid { get; set; }

    public int? Documentid { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public byte? Workerrecievelumpsumsection56a { get; set; }

    public DateTime? Workerrecievelumpsumelecteddate { get; set; }

    public decimal? Nwewhen56achecked { get; set; }

    public byte? Override56aentitlement { get; set; }

    public decimal? Override56aentitlementamount { get; set; }

    public virtual ParProvider? Assessmentprovider { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ClmPermimpaireconomicSaX? ClmPermimpaireconomicSaX { get; set; }

    public virtual ICollection<ClmPermimpairinjurySa> ClmPermimpairinjurySas { get; set; } = new List<ClmPermimpairinjurySa>();

    public virtual DmsDocument? Document { get; set; }
}
