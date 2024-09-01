using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VevtAssociateduser
{
    public int Eventid { get; set; }

    public int Hrid { get; set; }

    public int? Userid { get; set; }
}
