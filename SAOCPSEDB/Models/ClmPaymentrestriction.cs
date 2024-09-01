using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPaymentrestriction
{
    public int Claimid { get; set; }

    public int Paymentrestrictionno { get; set; }

    public DateTime? Datefrom { get; set; }

    public DateTime? Dateto { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public short? Allcategoriestypes { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public string? Reason { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual SecUser? EnteredbyNavigation { get; set; }
}
