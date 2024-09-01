using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncPsychologicalotherpeopleX
{
    public int Incidentid { get; set; }

    public int Personno { get; set; }

    public string? Relationshiptype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Inchrid { get; set; }

    public string? Surname { get; set; }

    public string? Firstname { get; set; }

    public virtual IncHrdataX? Inchr { get; set; }

    public virtual IncPsychologicalX Incident { get; set; } = null!;
}
