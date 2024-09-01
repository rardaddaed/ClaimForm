using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmEventnotificationorgstructX
{
    public int Eventnotificationid { get; set; }

    public int Orgstructno { get; set; }

    public int? Orgstructid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual AdmEventnotificationX Eventnotification { get; set; } = null!;
}
