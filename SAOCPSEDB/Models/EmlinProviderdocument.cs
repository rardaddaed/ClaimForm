using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EmlinProviderdocument
{
    public int Emailid { get; set; }

    public int Attachno { get; set; }

    public int? Partyid { get; set; }

    public int? Correspondenceinid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EmlinEmail Email { get; set; } = null!;

    public virtual ParParty? Party { get; set; }
}
