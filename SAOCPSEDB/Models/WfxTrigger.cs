using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfxTrigger
{
    public int Entityid { get; set; }

    public string Entitytype { get; set; } = null!;

    public DateTime? Triggerid { get; set; }

    public string? Triggertype { get; set; }

    public int? Unprocessed { get; set; }

    public string? Clustertype { get; set; }

    public int? Clusterid { get; set; }

    public Guid? Entityguid { get; set; }

    public Guid? Triggerguid { get; set; }

    public int Triggerdataid { get; set; }
}
