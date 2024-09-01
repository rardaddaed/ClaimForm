using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PorTicketX
{
    public int Ticketid { get; set; }

    public string? Ticketnumber { get; set; }

    public DateTime? Ticketdatetime { get; set; }

    public int? Userid { get; set; }

    public string? Targetdestination { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
