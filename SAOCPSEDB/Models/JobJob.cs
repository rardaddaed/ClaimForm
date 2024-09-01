using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class JobJob
{
    public int Jobid { get; set; }

    public string? Jobtype { get; set; }

    public string? Jobdescription { get; set; }

    public int? Ownerid { get; set; }

    public DateTime? Dateownerchanged { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<JobQueue> JobQueues { get; set; } = new List<JobQueue>();

    public virtual ICollection<JobRecipient> JobRecipients { get; set; } = new List<JobRecipient>();

    public virtual SecUser? Owner { get; set; }

    public virtual ICollection<SchSchedule> SchSchedules { get; set; } = new List<SchSchedule>();
}
