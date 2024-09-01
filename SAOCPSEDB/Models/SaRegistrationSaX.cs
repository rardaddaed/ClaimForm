using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SaRegistrationSaX
{
    public int Saregistrationid { get; set; }

    public int Organisationno { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Agency { get; set; }

    public string? Level1 { get; set; }

    public string? Level2 { get; set; }

    public virtual SaRegistrationSa Saregistration { get; set; } = null!;
}
