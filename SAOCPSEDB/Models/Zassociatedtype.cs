using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Zassociatedtype
{
    public string AssociatedType { get; set; } = null!;

    public string? AssociatedDescr { get; set; }

    public string? AssociatedDefinition { get; set; }

    public string? Code1Type { get; set; }

    public string? Code2Type { get; set; }

    public short? Flags { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual Zprimarycodedef? Code1TypeNavigation { get; set; }

    public virtual Zprimarycodedef? Code2TypeNavigation { get; set; }

    public virtual ICollection<Zassociatedcode> Zassociatedcodes { get; set; } = new List<Zassociatedcode>();
}
