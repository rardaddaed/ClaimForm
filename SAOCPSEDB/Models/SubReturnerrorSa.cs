using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SubReturnerrorSa
{
    public int Returnid { get; set; }

    public int Returnerrorno { get; set; }

    public string? Errortype { get; set; }

    public string? Claimnumber { get; set; }

    public string? Errormessage { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SubReturnSa Return { get; set; } = null!;
}
