using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsInsurer
{
    public int Insurerid { get; set; }

    public string? Insurername { get; set; }

    public string? Insurercode { get; set; }

    public int? Insureruserid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmInsurerIn> ClmInsurerIns { get; set; } = new List<ClmInsurerIn>();

    public virtual ICollection<InsBatch> InsBatches { get; set; } = new List<InsBatch>();

    public virtual SecUser Insurer { get; set; } = null!;
}
