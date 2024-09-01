using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class LegLegalentityX
{
    public int Legalentityid { get; set; }

    public string? Faxnumber { get; set; }

    public int? Documentid { get; set; }

    public string? Websiteaddress { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual LegLegalentity Legalentity { get; set; } = null!;
}
