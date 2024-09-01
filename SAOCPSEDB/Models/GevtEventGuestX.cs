using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtEventGuestX
{
    public int Geventid { get; set; }

    public string? Guestformstatus { get; set; }

    public string? Enteredbyemail { get; set; }

    public string? Actiontakenbyname { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual GevtEventX Gevent { get; set; } = null!;
}
