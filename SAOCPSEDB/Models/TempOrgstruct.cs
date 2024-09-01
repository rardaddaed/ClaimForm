using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class TempOrgstruct
{
    public string? OrgId { get; set; }

    public string? OrgCode { get; set; }

    public string? OrgDescription { get; set; }

    public string? ParentOrgId { get; set; }

    public string? OrgLevel { get; set; }

    public string? Active { get; set; }

    public string? AuditLastModified { get; set; }
}
