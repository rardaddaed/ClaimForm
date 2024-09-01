using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParEmployeenamehistory
{
    public int Partyid { get; set; }

    public int Employeenamehistoryno { get; set; }

    public DateTime? Datenamechanged { get; set; }

    public string? Familyname { get; set; }

    public string? Givennames { get; set; }

    public string? Namechangereason { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Middlenames { get; set; }

    public string? Employeenumber { get; set; }

    public virtual ParParty Party { get; set; } = null!;
}
