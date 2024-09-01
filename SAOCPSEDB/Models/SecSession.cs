using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecSession
{
    public short Spid { get; set; }

    public int? Userid { get; set; }

    public string? Token { get; set; }

    public DateTime? Starttime { get; set; }
}
