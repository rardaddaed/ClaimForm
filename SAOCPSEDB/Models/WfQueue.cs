using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfQueue
{
    public int Workflowqueueid { get; set; }

    public string? Clustertype { get; set; }

    public int? Clusterid { get; set; }

    public DateTime? Datetimequeued { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdatetime { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
