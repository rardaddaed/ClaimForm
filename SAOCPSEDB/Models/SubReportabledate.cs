using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SubReportabledate
{
    public int Reportableid { get; set; }

    public int Reportabledateno { get; set; }

    public DateTime? Reportabledate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Reportabledatetype { get; set; }

    public virtual SubReportable Reportable { get; set; } = null!;
}
