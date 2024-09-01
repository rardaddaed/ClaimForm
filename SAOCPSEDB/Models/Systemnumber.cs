using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Systemnumber
{
    public string Numbertype { get; set; } = null!;

    public string Identifier { get; set; } = null!;

    public int? Systemnumber1 { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
