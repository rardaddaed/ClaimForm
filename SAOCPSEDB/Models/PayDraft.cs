using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayDraft
{
    public int Paymentid { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? Reason { get; set; }

    public int? Rejected { get; set; }

    public int? Rejectedbyid { get; set; }

    public int? Linked { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Notes { get; set; }

    public Guid? Portalguid { get; set; }

    public string? Portalentrymethod { get; set; }

    public byte? Hasinvoicetobescanned { get; set; }

    public virtual PayPayment Payment { get; set; } = null!;

    public virtual SecUser? Rejectedby { get; set; }
}
