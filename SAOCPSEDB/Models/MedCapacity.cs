using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MedCapacity
{
    public int Medcertid { get; set; }

    public int Capacityno { get; set; }

    public string? Capacitycodetype { get; set; }

    public string? Capacity { get; set; }

    public int? Applicable { get; set; }

    public DateTime? Datefrom { get; set; }

    public DateTime? Dateto { get; set; }

    public decimal? Hoursperday { get; set; }

    public int? Daysperweek { get; set; }

    public int? Normalhours { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual MedCapacitySa? MedCapacitySa { get; set; }

    public virtual MedMedcert Medcert { get; set; } = null!;
}
