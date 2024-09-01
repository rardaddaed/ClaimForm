using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmHirmemailX
{
    public int Hirmemailid { get; set; }

    public string? Email { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
