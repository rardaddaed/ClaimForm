using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class OsOrgstructureXBak
{
    public int Orgstructid { get; set; }

    public string? Portfolio { get; set; }

    public string? Region { get; set; }

    public string? Agency { get; set; }

    public string? Service { get; set; }

    public string? Division { get; set; }

    public string? Costcentre { get; set; }

    public string? Organisationunit { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
