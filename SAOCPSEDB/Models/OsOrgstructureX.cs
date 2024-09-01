using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class OsOrgstructureX
{
    public int Orgstructid { get; set; }

    public string? Agency { get; set; }

    public string? Level1 { get; set; }

    public string? Level2 { get; set; }

    public string? Level3 { get; set; }

    public string? Level4 { get; set; }

    public string? Level5 { get; set; }

    public string? Level6 { get; set; }

    public string? Level7 { get; set; }

    public int? Heirarchyid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual OsOrgstructure Orgstruct { get; set; } = null!;
}
