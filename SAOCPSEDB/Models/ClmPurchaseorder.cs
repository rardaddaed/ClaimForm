using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPurchaseorder
{
    public int Claimid { get; set; }

    public int Purchaseorderno { get; set; }

    public string? Referencenumber { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? Notes { get; set; }

    public int? Providerid { get; set; }

    public int? Providerlocationo { get; set; }

    public short? Notifyviaemail { get; set; }

    public int? Receivingpartyid { get; set; }

    public int? Receivinglocationo { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public short? International { get; set; }

    public string? Country { get; set; }

    public string? Otherconditions { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmPurchaseauth> ClmPurchaseauths { get; set; } = new List<ClmPurchaseauth>();

    public virtual ICollection<ClmPurchaseitem> ClmPurchaseitems { get; set; } = new List<ClmPurchaseitem>();

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual ParLocation? ParLocation { get; set; }

    public virtual ParLocation? ParLocationNavigation { get; set; }
}
