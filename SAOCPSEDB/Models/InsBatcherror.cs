using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsBatcherror
{
    public int Insbatchid { get; set; }

    public int Batcherrorno { get; set; }

    public string? Fileidentifier { get; set; }

    public int? Rownumber { get; set; }

    public string? Keyvalue { get; set; }

    public string? Keyvalue2 { get; set; }

    public string? Keyvalue3 { get; set; }

    public string? Description { get; set; }

    public string? Severity { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
