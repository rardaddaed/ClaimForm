using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HrBatchX
{
    public int Batchid { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<HrBatchErrorsX> HrBatchErrorsXes { get; set; } = new List<HrBatchErrorsX>();

    public virtual ICollection<HrBatchStagingX> HrBatchStagingXes { get; set; } = new List<HrBatchStagingX>();
}
