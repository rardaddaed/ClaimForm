using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsTimeoffwork
{
    public int Insurerloadid { get; set; }

    public int Instimeoffworkno { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public DateTime? Dateceasedwork { get; set; }

    public DateTime? Timeceasedwork { get; set; }

    public DateTime? Estimatedreturndate { get; set; }

    public DateTime? Returndate { get; set; }

    public DateTime? Returntime { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsInsurerload Insurerload { get; set; } = null!;
}
