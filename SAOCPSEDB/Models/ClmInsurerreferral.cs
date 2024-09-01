using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmInsurerreferral
{
    public int Claimid { get; set; }

    public int Referralno { get; set; }

    public DateTime? Referredtoinsurerdate { get; set; }

    public string? Referralnumber { get; set; }

    public string? Referraltype { get; set; }

    public string? Insurer { get; set; }

    public string? Policynumber { get; set; }

    public decimal? Excessamount { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
