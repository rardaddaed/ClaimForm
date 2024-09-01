using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmTreatmentstatushistory
{
    public int Claimid { get; set; }

    public int Treatmentno { get; set; }

    public int Statushistoryno { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public int? Userid { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public virtual ClmTreatment ClmTreatment { get; set; } = null!;

    public virtual SecUser? User { get; set; }
}
