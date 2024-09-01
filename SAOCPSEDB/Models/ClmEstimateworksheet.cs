using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmEstimateworksheet
{
    public int Claimid { get; set; }

    public int Estimateworksheetno { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Dateapplied { get; set; }

    public int? Appliedby { get; set; }

    public string? Comments { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Reasonforchange { get; set; }

    public virtual SecUser? AppliedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ClmEstimateworksheetSa? ClmEstimateworksheetSa { get; set; }

    public virtual ICollection<ClmEstimateworksheetdocument> ClmEstimateworksheetdocuments { get; set; } = new List<ClmEstimateworksheetdocument>();

    public virtual SecUser? EnteredbyNavigation { get; set; }
}
