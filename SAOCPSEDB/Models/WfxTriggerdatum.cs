using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfxTriggerdatum
{
    public int Triggerdataid { get; set; }

    public string? Entitytype { get; set; }

    public int? Entityid { get; set; }

    public string? Triggertype { get; set; }

    public DateTime? Triggerid { get; set; }

    public int? Subsequententityid { get; set; }

    public Guid? Entityguid { get; set; }

    public int? Unprocessed { get; set; }

    public Guid? Triggerguid { get; set; }
}
