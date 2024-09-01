using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WhsBatchX
{
    public int Batchid { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<WhsBatchErrorsX> WhsBatchErrorsXes { get; set; } = new List<WhsBatchErrorsX>();

    public virtual ICollection<WhsBatchStagingX> WhsBatchStagingXes { get; set; } = new List<WhsBatchStagingX>();
}
