using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPayment
{
    public int Claimid { get; set; }

    public int Paymentno { get; set; }

    public int? Paymentid { get; set; }

    public DateTime? Submissiondate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual PayPayment? Payment { get; set; }
}
