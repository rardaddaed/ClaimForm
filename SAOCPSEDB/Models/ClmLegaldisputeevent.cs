using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmLegaldisputeevent
{
    public int Claimid { get; set; }

    public int Legalno { get; set; }

    public int Eventno { get; set; }

    public DateTime? Eventdate { get; set; }

    public DateTime? Eventtime { get; set; }

    public string? Eventtype { get; set; }

    public string? Venue { get; set; }

    public string? Attendees { get; set; }

    public string? Outcome { get; set; }

    public DateTime? Outcomedate { get; set; }

    public string? Comments { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public decimal? Offeramount { get; set; }

    public virtual ClmLegaldispute ClmLegaldispute { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }
}
