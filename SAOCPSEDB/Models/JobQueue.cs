using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class JobQueue
{
    public int Jobqueueid { get; set; }

    public int? Jobid { get; set; }

    public DateTime? Queueddatetime { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdatetime { get; set; }

    public string? Statusdescription { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual JobJob? Job { get; set; }
}
