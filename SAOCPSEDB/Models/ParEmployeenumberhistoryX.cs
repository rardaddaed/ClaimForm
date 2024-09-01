using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParEmployeenumberhistoryX
{
    public int Partyid { get; set; }

    public int Historyno { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Employeenumber { get; set; }

    public string? Numberchangereason { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ParParty Party { get; set; } = null!;
}
