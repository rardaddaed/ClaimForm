using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IfnFilenoteX
{
    public int Filenoteid { get; set; }

    public string? Category { get; set; }

    public string? Subject { get; set; }

    public string? Note { get; set; }

    public int? Enteredbyhrid { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Timeentered { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Recordtype { get; set; }

    public short? Confidential { get; set; }

    public virtual HrDatum? Enteredbyhr { get; set; }

    public virtual ICollection<EvtFilenoteX> EvtFilenoteXes { get; set; } = new List<EvtFilenoteX>();
}
