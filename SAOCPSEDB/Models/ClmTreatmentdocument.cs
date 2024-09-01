using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmTreatmentdocument
{
    public int Claimid { get; set; }

    public int Treatmentno { get; set; }

    public int Treatmentdocumentno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Documenttype { get; set; }

    public DateTime? Documentdate { get; set; }

    public virtual ClmTreatment ClmTreatment { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }
}
