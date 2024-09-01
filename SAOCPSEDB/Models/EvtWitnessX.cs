using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtWitnessX
{
    public int Eventid { get; set; }

    public int Witnessno { get; set; }

    public string? Persontype { get; set; }

    public string? Nonemployeetype { get; set; }

    public int? Hrid { get; set; }

    public string? Givennames { get; set; }

    public string? Familyname { get; set; }

    public string? Phonenumber { get; set; }

    public string? Emailaddress { get; set; }

    public string? Otherdetails { get; set; }

    public string? Descriptionofevent { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;

    public virtual HrDatum? Hr { get; set; }
}
