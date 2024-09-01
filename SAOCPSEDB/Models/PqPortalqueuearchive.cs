using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PqPortalqueuearchive
{
    public int Queuearchiveid { get; set; }

    public int? Portalqueueid { get; set; }

    public string Objecttype { get; set; } = null!;

    public Guid Objectguid { get; set; }

    public string? Actiontype { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdatetime { get; set; }

    public DateTime? Archivedatetime { get; set; }

    public DateTime? Queuerecorddateentered { get; set; }

    public int? Queuerecordenteredby { get; set; }

    public DateTime? Queuerecorddatemodified { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
