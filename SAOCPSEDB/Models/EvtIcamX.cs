using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtIcamX
{
    public int Eventid { get; set; }

    public string? Absentcomments { get; set; }

    public string? Individualteamcomments { get; set; }

    public string? Orgfactorcomments { get; set; }

    public string? Taskenvironmentcomments { get; set; }

    public short? Isolatemakesafe { get; set; }

    public string? Isolatemakesafecomments { get; set; }

    public short? Notifystakeholders { get; set; }

    public string? Notifystakeholderscomments { get; set; }

    public short? Medicalassistance { get; set; }

    public string? Medicalassistancecomments { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
