using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParFinstatushistory
{
    public int Partyid { get; set; }

    public int Finstatushistoryno { get; set; }

    public string? Financialstatus { get; set; }

    public DateTime? Statusdate { get; set; }

    public int? Userid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ParFinance Party { get; set; } = null!;

    public virtual SecUser? User { get; set; }
}
