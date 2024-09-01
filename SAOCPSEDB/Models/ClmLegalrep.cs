using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmLegalrep
{
    public int Claimid { get; set; }

    public int Legalrepno { get; set; }

    public int? Legalreppartyid { get; set; }

    public int? Legalreplocationno { get; set; }

    public int? Legalrepcontactno { get; set; }

    public int? Legalreptype { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Certificateprovided { get; set; }

    public short? Certificateuploaded { get; set; }

    public DateTime? Certificatedate { get; set; }

    public string? Lawpracticename { get; set; }

    public string? Lawpracticepostcode { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ParParty? Legalrepparty { get; set; }

    public virtual ParContact? ParContact { get; set; }

    public virtual ParLocation? ParLocation { get; set; }
}
