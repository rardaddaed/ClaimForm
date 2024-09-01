using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmSmstemplate
{
    public int Smstemplateid { get; set; }

    public string? Smstitle { get; set; }

    public short? Active { get; set; }

    public string? Smsmessage { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
