using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmEventnotificationeventsubtypeX
{
    public int Eventnotificationid { get; set; }

    public int Eventsubtypeno { get; set; }

    public string? Eventsubtype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual AdmEventnotificationX Eventnotification { get; set; } = null!;
}
