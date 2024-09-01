using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtSecurityX
{
    public int Hrid { get; set; }

    public int Eventid { get; set; }

    public int? Versionnumber { get; set; }

    public virtual HrDatum Hr { get; set; } = null!;
}
