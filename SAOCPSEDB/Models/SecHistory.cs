using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecHistory
{
    public int Userid { get; set; }

    public int Historyno { get; set; }

    public string? Clustertype { get; set; }

    public int? Keyvalue { get; set; }

    public int? Sortorder { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser User { get; set; } = null!;
}
