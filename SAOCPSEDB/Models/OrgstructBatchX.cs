using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class OrgstructBatchX
{
    public int Batchid { get; set; }

    public DateTime? Datetimeentered { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<OrgstructErrorsX> OrgstructErrorsXes { get; set; } = new List<OrgstructErrorsX>();

    public virtual ICollection<OrgstructStagingX> OrgstructStagingXes { get; set; } = new List<OrgstructStagingX>();
}
