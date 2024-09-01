using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmSpecialdate
{
    public int Specialdateid { get; set; }

    public int? Jurisdictionzone { get; set; }

    public DateTime? Specialdate { get; set; }

    public string? Datetype { get; set; }

    public string? Description { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
