using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmCasemanagementplanbarrier
{
    public int Claimid { get; set; }

    public int Casemanagementplanno { get; set; }

    public int Barrierno { get; set; }

    public string? Barrier { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmCasemanagementplan ClmCasemanagementplan { get; set; } = null!;
}
