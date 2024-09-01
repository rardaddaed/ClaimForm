using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecObject
{
    public int Objectid { get; set; }

    public int? Type { get; set; }

    public string? Description { get; set; }

    public int? Parent { get; set; }

    public string? Reference { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<SecObject> InverseParentNavigation { get; set; } = new List<SecObject>();

    public virtual SecObject? ParentNavigation { get; set; }

    public virtual ICollection<SecPermission> SecPermissions { get; set; } = new List<SecPermission>();
}
