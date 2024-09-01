using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncPersoninvolvedX
{
    public int Incidentid { get; set; }

    public int? Personinvolved { get; set; }

    public int? Persontype { get; set; }

    public string? Nonemployeetype { get; set; }

    public int? Hrid { get; set; }

    public string? Employeenumber { get; set; }

    public string? Givennames { get; set; }

    public string? Familyname { get; set; }

    public string? Occupation { get; set; }

    public string? Company { get; set; }

    public string? Email { get; set; }

    public string? Altemail { get; set; }

    public string? Phone { get; set; }

    public string? Altphone { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Gender { get; set; }

    public virtual IncHrdataX? Hr { get; set; }

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
