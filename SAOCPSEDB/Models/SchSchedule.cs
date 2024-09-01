using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SchSchedule
{
    public int Scheduleid { get; set; }

    public int? Active { get; set; }

    public string? Frequency { get; set; }

    public DateTime? Timeofday { get; set; }

    public int? Dayofmonth { get; set; }

    public int? Month { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Modifiedby { get; set; }

    public int? Jobid { get; set; }

    public DateTime? Datemodified { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual JobJob? Job { get; set; }

    public virtual SecUser? ModifiedbyNavigation { get; set; }

    public virtual ICollection<RptReport> RptReports { get; set; } = new List<RptReport>();

    public virtual ICollection<SchDayofweek> SchDayofweeks { get; set; } = new List<SchDayofweek>();
}
