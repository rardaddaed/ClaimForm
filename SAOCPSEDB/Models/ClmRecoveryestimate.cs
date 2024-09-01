using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmRecoveryestimate
{
    public int Claimid { get; set; }

    public int Recoveryestimateno { get; set; }

    public string? Recoveryestimatecategory { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public string? Reason { get; set; }

    public decimal? Estimatedrecoveryamount { get; set; }

    public int? Changedbyuserid { get; set; }

    public int? Transactionid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser? Changedbyuser { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual GlTransaction? Transaction { get; set; }
}
