using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Evt5whyX
{
    public int Eventid { get; set; }

    public string? Problemstatement { get; set; }

    public string? Firstwhy { get; set; }

    public string? Secondwhy { get; set; }

    public string? Thirdwhy { get; set; }

    public string? Fourthwhy { get; set; }

    public string? Fifthwhy { get; set; }

    public string? Rootcause { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
