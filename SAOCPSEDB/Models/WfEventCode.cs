using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfEventCode
{
    public int Eventid { get; set; }

    public int Codeno { get; set; }

    public string? Codetype { get; set; }

    public string? Codevalue { get; set; }

    public int? Fromto { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual WfEvent Event { get; set; } = null!;
}
