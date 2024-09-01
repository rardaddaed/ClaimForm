using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfxEntity
{
    public string Entitytype { get; set; } = null!;

    public int Entityid { get; set; }

    public string? Clustertype { get; set; }

    public int? Clusterid { get; set; }

    public DateTime? Entitytime { get; set; }

    public Guid? Guid { get; set; }
}
