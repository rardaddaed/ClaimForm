using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerCustom
{
    public int Customserviceid { get; set; }

    public string? Item { get; set; }

    public string? Source { get; set; }

    public DateTime? Datediscontinued { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<SerCustomdescription> SerCustomdescriptions { get; set; } = new List<SerCustomdescription>();

    public virtual ICollection<SerCustomrate> SerCustomrates { get; set; } = new List<SerCustomrate>();
}
