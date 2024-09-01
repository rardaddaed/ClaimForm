using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmMergefield
{
    public int Mergefieldid { get; set; }

    public string? Alias { get; set; }

    public string? Fieldformula { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public byte[]? Timestamp { get; set; }
}
