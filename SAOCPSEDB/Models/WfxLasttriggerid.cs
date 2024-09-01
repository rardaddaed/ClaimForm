using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfxLasttriggerid
{
    public int Entityid { get; set; }

    public string Entitytype { get; set; } = null!;

    public DateTime? Lastriggerid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
