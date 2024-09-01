using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmCovidsymptom
{
    public int Claimid { get; set; }

    public int Covidisolationno { get; set; }

    public int Covidsymptomno { get; set; }

    public string? Symptom { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmCovidisolation ClmCovidisolation { get; set; } = null!;
}
