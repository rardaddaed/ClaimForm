using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class BaseParNumber
{
    public int Partyid { get; set; }

    public string Numbertypecodetype { get; set; } = null!;

    public string? Numbertype { get; set; }

    public string? Number { get; set; }
}
