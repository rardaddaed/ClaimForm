using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtRegnotificationX
{
    public int Eventid { get; set; }

    public int Notificationno { get; set; }

    public string? Regulatornotified { get; set; }

    public string? Notifiableincidenttype { get; set; }

    public string? Injuryillnesstype { get; set; }

    public string? Dangerousincidenttype { get; set; }

    public DateTime? Datereportedtoregulator { get; set; }

    public DateTime? Timereportedtoregulator { get; set; }

    public string? Idnumber { get; set; }

    public string? Filenumber { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
