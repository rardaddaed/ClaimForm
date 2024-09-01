using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerAma
{
    public int Amaserviceid { get; set; }

    public string? Item { get; set; }

    public DateTime? Datediscontinued { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<SerAmadescription> SerAmadescriptions { get; set; } = new List<SerAmadescription>();

    public virtual ICollection<SerAmarate> SerAmarates { get; set; } = new List<SerAmarate>();
}
