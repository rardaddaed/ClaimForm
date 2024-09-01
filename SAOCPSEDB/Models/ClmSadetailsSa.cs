using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmSadetailsSa
{
    public int Claimid { get; set; }

    public DateTime? Dateoffirstincapacity { get; set; }

    public DateTime? Swsaadvisorydate { get; set; }

    public short? Futuremedicalexpensesapproved { get; set; }

    public short? Saseriousinjury { get; set; }

    public DateTime? Seriousinjuryassessmentdate { get; set; }

    public string? Workercommonlawdecision { get; set; }

    public short? Transitioned { get; set; }

    public DateTime? Datetransitioned { get; set; }

    public DateTime? Transitiondesignateddate { get; set; }

    public int? Totalweekspaidattransition { get; set; }

    public string? Transitioncategory { get; set; }

    public DateTime? Rdidischargedate { get; set; }

    public decimal? Rdidischargenweamount { get; set; }

    public decimal? Rdidischargeweeklyamount { get; set; }

    public short? Rdidischargeseriouslyinjured { get; set; }

    public DateTime? Dordischargedate { get; set; }

    public decimal? Dordischargenweamount { get; set; }

    public decimal? Dordischargeweeklyamount { get; set; }

    public DateTime? Rdmdischargedate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public DateTime? Lumpsumdatedischarged { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
