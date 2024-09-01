using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PqPortalqueue
{
    public int Portalqueueid { get; set; }

    public string Objecttype { get; set; } = null!;

    public Guid Objectguid { get; set; }

    public string? Actiontype { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdatetime { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
