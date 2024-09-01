using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class OrgstructErrorsX
{
    public int Batchid { get; set; }

    public int Errorno { get; set; }

    public int? Rownumber { get; set; }

    public string? Errortype { get; set; }

    public string? Errordesc { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual OrgstructBatchX Batch { get; set; } = null!;
}
