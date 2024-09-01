using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmDeterminationSa
{
    public int Claimid { get; set; }

    public string? Determinationcodetype { get; set; }

    public string? Determination { get; set; }

    public short? Interimpayments { get; set; }

    public DateTime? Datedetermined { get; set; }

    public DateTime? Datedeterminationchanged { get; set; }

    public DateTime? Dateperiodfrom { get; set; }

    public DateTime? Dateperiodto { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ClmDeterminationSaX? ClmDeterminationSaX { get; set; }

    public virtual ICollection<ClmDeterminationhistorySa> ClmDeterminationhistorySas { get; set; } = new List<ClmDeterminationhistorySa>();
}
