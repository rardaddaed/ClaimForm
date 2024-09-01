using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class DmsDocumentreviewhistory
{
    public int Documentid { get; set; }

    public int Reviewhistoryno { get; set; }

    public short? Reviewed { get; set; }

    public DateTime? Datereviewed { get; set; }

    public DateTime? Timereviewed { get; set; }

    public int? Reviewedby { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public int? Changedby { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual DmsDocument Document { get; set; } = null!;
}
