using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtRelateduser
{
    public int Eventid { get; set; }

    public string Recordtype { get; set; } = null!;

    public int? Hrid { get; set; }
}
