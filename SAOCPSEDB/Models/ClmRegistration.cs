using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRegistration
{
    public int Claimid { get; set; }

    public string? Registration { get; set; }

    public string? Reason { get; set; }

    public DateTime? Registrationdate { get; set; }

    public DateTime? Dateregistrationchanged { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
