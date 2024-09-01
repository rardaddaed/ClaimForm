using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtPwresettokenX
{
    public int Id { get; set; }

    public int? Hrid { get; set; }

    public string? Email { get; set; }

    public DateTime? Datetimecreated { get; set; }

    public DateTime? Datetimeexpired { get; set; }

    public byte? Isconsumed { get; set; }

    public string Tokenguid { get; set; } = null!;

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual HrDatum? Hr { get; set; }
}
