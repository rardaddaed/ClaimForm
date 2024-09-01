using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParContacthistory
{
    public int Partyid { get; set; }

    public int Locationno { get; set; }

    public int Contactno { get; set; }

    public int Contacthistoryno { get; set; }

    public DateTime? Datechanged { get; set; }

    public string? Phone { get; set; }

    public string? Workphone { get; set; }

    public string? Mobilephone { get; set; }

    public string? Email { get; set; }

    public string? Contactname { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ParContact ParContact { get; set; } = null!;
}
