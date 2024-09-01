using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmClaimX
{
    public int Claimid { get; set; }

    public int? Claimsequencenumber { get; set; }

    public string? Receiptmethod { get; set; }

    public DateTime? Daterehabreferred { get; set; }

    public DateTime? Daterehabreceived { get; set; }

    public DateTime? Firstcontactdate { get; set; }

    public short? Provisionalliability { get; set; }

    public short? Claimiscoded { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public int? Placementrequired { get; set; }

    public string? Placementdetails { get; set; }

    public DateTime? Rtwdate4week { get; set; }

    public DateTime? Rtwdate13week { get; set; }

    public DateTime? Rtwdate26week { get; set; }

    public DateTime? Rtwdate52week { get; set; }

    public DateTime? Rtwdate78week { get; set; }

    public DateTime? Rtwdate103week { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
