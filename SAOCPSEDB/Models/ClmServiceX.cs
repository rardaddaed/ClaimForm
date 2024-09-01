using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmServiceX
{
    public int Claimid { get; set; }

    public int Serviceno { get; set; }

    public DateTime? Dateofservice { get; set; }

    public int? Simsuser { get; set; }

    public string? Typeofservice { get; set; }

    public string? Servicesubtype { get; set; }

    public string? Comments { get; set; }

    public decimal? Billabletimeunits { get; set; }

    public decimal? Nonbillabletimeunits { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual SecUser? SimsuserNavigation { get; set; }
}
