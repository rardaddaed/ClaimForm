using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class TempOrgstructTj
{
    public DateTime? AuditCreated { get; set; }

    public DateTime? AuditLastModified { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? Active { get; set; }

    public string? OrgHierarchyId { get; set; }

    public string? OrgCode { get; set; }

    public string? OrgDescription { get; set; }

    public int? OrgLevel { get; set; }

    public string? OrgParentHierarchyId { get; set; }
}
