using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmFilenotetemplate
{
    public int Filenotetemplateid { get; set; }

    public string? Filenotetitle { get; set; }

    public short? Active { get; set; }

    public string? Notes { get; set; }

    public string? Subject { get; set; }

    public string? Category { get; set; }

    public string? Filenotedescription { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Filenotetype { get; set; }
}
