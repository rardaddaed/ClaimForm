using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class UtilParNumber
{
    public int Partyid { get; set; }

    public string Numbertypecodetype { get; set; } = null!;

    public string? Numbertype { get; set; }

    public string? Number { get; set; }
}
