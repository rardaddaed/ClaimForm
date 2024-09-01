using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class DmsPersonrespClaim
{
    public int Documentid { get; set; }

    public int Personrespno { get; set; }

    public int? Userid { get; set; }

    public int? Claimid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1? Claim { get; set; }

    public virtual DmsDocument Document { get; set; } = null!;
}
