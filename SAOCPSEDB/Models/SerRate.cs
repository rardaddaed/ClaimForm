using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerRate
{
    public int Servicerateid { get; set; }

    public string? Taxstatus { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<SerAmarate> SerAmarates { get; set; } = new List<SerAmarate>();

    public virtual ICollection<SerCustomrate> SerCustomrates { get; set; } = new List<SerCustomrate>();

    public virtual ICollection<SerPrivatehosprateSa> SerPrivatehosprateSas { get; set; } = new List<SerPrivatehosprateSa>();

    public virtual ICollection<SerSaschedulerateSa> SerSaschedulerateSas { get; set; } = new List<SerSaschedulerateSa>();
}
