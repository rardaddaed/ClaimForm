using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmOtheremployment
{
    public int Claimid { get; set; }

    public int Otheremploymentno { get; set; }

    public string? Employername { get; set; }

    public string? Addressline1 { get; set; }

    public string? Addressline2 { get; set; }

    public string? Addressline3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? International { get; set; }

    public string? Country { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public decimal? Weeklyearnings { get; set; }

    public decimal? Normalhoursperweek { get; set; }

    public int? Normaldaysperweek { get; set; }

    public string? Phone { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
