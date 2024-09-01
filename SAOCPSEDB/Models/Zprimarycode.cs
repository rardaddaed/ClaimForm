using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Zprimarycode
{
    public int Zone { get; set; }

    public string CodeType { get; set; } = null!;

    public string CodeValue { get; set; } = null!;

    public string? DisplayValue { get; set; }

    public int? UserFlag { get; set; }

    public string? UserField { get; set; }

    public string? AggregateType { get; set; }

    public string? AggregateValue { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public byte[]? Timestamp { get; set; }

    public Guid? Guid { get; set; }

    public virtual Zprimarycodedef CodeTypeNavigation { get; set; } = null!;

    public virtual ICollection<Zmappedcode> ZmappedcodeZprimarycodeNavigations { get; set; } = new List<Zmappedcode>();

    public virtual ICollection<Zmappedcode> ZmappedcodeZprimarycodes { get; set; } = new List<Zmappedcode>();
}
