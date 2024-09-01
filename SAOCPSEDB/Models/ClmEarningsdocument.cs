using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmEarningsdocument
{
    public int Claimid { get; set; }

    public int Earningsdocumentno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }
}
