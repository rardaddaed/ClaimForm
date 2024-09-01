using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SaRegistrationlocationSa
{
    public int Saregistrationid { get; set; }

    public int Saworkcoverlocationid { get; set; }

    public DateTime? Datelinked { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SaRegistrationSa Saregistration { get; set; } = null!;

    public virtual SaWorkcoverlocationSa Saworkcoverlocation { get; set; } = null!;
}
