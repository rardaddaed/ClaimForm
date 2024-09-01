using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerSascheduleSa
{
    public int Sascheduleid { get; set; }

    public string? Item { get; set; }

    public string? Source { get; set; }

    public DateTime? Datediscontinued { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<SerSascheduledescriptionSa> SerSascheduledescriptionSas { get; set; } = new List<SerSascheduledescriptionSa>();

    public virtual ICollection<SerSaschedulerateSa> SerSaschedulerateSas { get; set; } = new List<SerSaschedulerateSa>();
}
