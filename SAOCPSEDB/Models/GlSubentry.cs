using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GlSubentry
{
    public int Transactionid { get; set; }

    public int Subentryno { get; set; }

    public int? Debitcredit { get; set; }

    public int? Accountid { get; set; }

    public decimal? Amount { get; set; }

    public string? Entrytype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual GlAccount? Account { get; set; }

    public virtual ICollection<PayItemsubentry> PayItemsubentries { get; set; } = new List<PayItemsubentry>();

    public virtual GlTransaction Transaction { get; set; } = null!;
}
