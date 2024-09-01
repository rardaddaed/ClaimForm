using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Zprimarycodedef
{
    public string CodeType { get; set; } = null!;

    public string? CodeTypeDescr { get; set; }

    public string? CodeTypeDefinition { get; set; }

    public string? AggregatedBy { get; set; }

    public short? Flags { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<Zassociatedtype> ZassociatedtypeCode1TypeNavigations { get; set; } = new List<Zassociatedtype>();

    public virtual ICollection<Zassociatedtype> ZassociatedtypeCode2TypeNavigations { get; set; } = new List<Zassociatedtype>();

    public virtual ICollection<Zprimarycode> Zprimarycodes { get; set; } = new List<Zprimarycode>();
}
