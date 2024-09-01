using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class OrgstructStagingX
{
    public int Batchid { get; set; }

    public int Rownumber { get; set; }

    public int? Invalid { get; set; }

    public string? Orghierarchyid { get; set; }

    public string? Orgcode { get; set; }

    public string? Orgdescription { get; set; }

    public int? Orglevel { get; set; }

    public string? Orgparenthierarchyid { get; set; }

    public DateTime? Validfrom { get; set; }

    public DateTime? Validto { get; set; }

    public string? Active { get; set; }

    public DateTime? AuditCreated { get; set; }

    public DateTime? AuditLastmodified { get; set; }

    public int? AuditRowversion { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual OrgstructBatchX Batch { get; set; } = null!;
}
