using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfxRole
{
    public string Entitytype { get; set; } = null!;

    public int Entityid { get; set; }

    public string? Clustertype { get; set; }

    public int? Clusterid { get; set; }

    public string? Role { get; set; }

    public int? Userid { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Fax { get; set; }
}
