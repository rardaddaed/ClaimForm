using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecPassword
{
    public int Userid { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public string? Salt { get; set; }

    public byte[]? Hashedpassword { get; set; }

    public int? Mustchange { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<SecPasswordhistory> SecPasswordhistories { get; set; } = new List<SecPasswordhistory>();

    public virtual SecUser User { get; set; } = null!;
}
