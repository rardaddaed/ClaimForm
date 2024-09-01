using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmLiabilityhistory
{
    public int Claimid { get; set; }

    public int Liabilityhistoryno { get; set; }

    public string? Liabilitycodetype { get; set; }

    public string? Liability { get; set; }

    public string? Liabilitydisplayvalue { get; set; }

    public DateTime? Liabilitydate { get; set; }

    public DateTime? Dateliabilitychanged { get; set; }

    public int? Changedby { get; set; }

    public Guid? Guid { get; set; }
}
