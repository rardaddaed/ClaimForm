using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Zassociatedcode
{
    public int Zone { get; set; }

    public string AssociatedType { get; set; } = null!;

    public string Code1Type { get; set; } = null!;

    public string Code2Type { get; set; } = null!;

    public string Code1Value { get; set; } = null!;

    public string Code2Value { get; set; } = null!;

    public int UserFlag { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual Zassociatedtype AssociatedTypeNavigation { get; set; } = null!;
}
