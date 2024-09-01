using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HrPasswordhistoryX
{
    public int Hrid { get; set; }

    public int Passwordno { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public string? Salt { get; set; }

    public byte[]? Hashedpassword { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual HrPasswordX Hr { get; set; } = null!;
}
