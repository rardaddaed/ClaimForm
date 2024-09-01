using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPurchaseauth
{
    public int Claimid { get; set; }

    public int Purchaseorderno { get; set; }

    public int Purchaseauthno { get; set; }

    public decimal? Authorisedamount { get; set; }

    public short? Authorised { get; set; }

    public int? Authorisedby { get; set; }

    public DateTime? Dateauthorised { get; set; }

    public int? Transactionid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? AuthorisedbyNavigation { get; set; }

    public virtual ClmPurchaseorder ClmPurchaseorder { get; set; } = null!;

    public virtual GlTransaction? Transaction { get; set; }
}
