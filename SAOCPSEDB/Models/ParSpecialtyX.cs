using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParSpecialtyX
{
    public int Partyid { get; set; }

    public int Specialtyno { get; set; }

    public string? Specialty { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ParParty Party { get; set; } = null!;
}
