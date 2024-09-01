using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GlRule
{
    public int Ruleid { get; set; }

    public int? Accountid { get; set; }

    public string? Entrytype { get; set; }

    public int? Debitaccountid { get; set; }

    public int? Creditaccountid { get; set; }

    public int? Debittaxid { get; set; }

    public int? Credittaxid { get; set; }

    public short? Active { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GlAccount? Account { get; set; }

    public virtual GlAccount? Creditaccount { get; set; }

    public virtual GlAccount? Credittax { get; set; }

    public virtual GlAccount? Debitaccount { get; set; }

    public virtual GlAccount? Debittax { get; set; }
}
