using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RptReport
{
    public int Reportid { get; set; }

    public string? Reportname { get; set; }

    public string? Reportreference { get; set; }

    public string? Reportcriteria { get; set; }

    public int? Scheduleid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<RptDocument> RptDocuments { get; set; } = new List<RptDocument>();

    public virtual SchSchedule? Schedule { get; set; }
}
