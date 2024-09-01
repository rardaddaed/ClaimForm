using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Zzone
{
    public int Zoneid { get; set; }

    public string? Zonename { get; set; }

    public string? Shortname { get; set; }

    public byte[]? Timestamp { get; set; }
}
