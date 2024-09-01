using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GlEntry
{
    public int Transactionid { get; set; }

    public int Entryno { get; set; }

    public short? Debitcredit { get; set; }

    public int? Accountid { get; set; }

    public decimal? Amount { get; set; }

    public string? Entrytype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GlAccount? Account { get; set; }

    public virtual GlTransaction Transaction { get; set; } = null!;
}
