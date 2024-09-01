using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmInsurerIn
{
    public int Claimid { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public string? Claimpolicynumber { get; set; }

    public string? Insurercasemanager { get; set; }

    public int? Insurerid { get; set; }

    public DateTime? Datelastinsurerupdate { get; set; }

    public string? Insurerphonenumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual InsInsurer? Insurer { get; set; }
}
