using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecPasswordhistory
{
    public int Userid { get; set; }

    public int Passwordno { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public string? Salt { get; set; }

    public byte[]? Hashedpassword { get; set; }

    public int? Mustchange { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecPassword User { get; set; } = null!;
}
