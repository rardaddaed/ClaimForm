using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParBusinessprovider
{
    public int Partyid { get; set; }

    public int Providerno { get; set; }

    public int? Providerid { get; set; }

    public DateTime? Datetimelinked { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ParBusiness Party { get; set; } = null!;

    public virtual ParProvider? Provider { get; set; }
}
