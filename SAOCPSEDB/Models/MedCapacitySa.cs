using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MedCapacitySa
{
    public int Medcertid { get; set; }

    public int Capacityno { get; set; }

    public short? Mayrequirefurthertreatment { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual MedCapacity MedCapacity { get; set; } = null!;
}
