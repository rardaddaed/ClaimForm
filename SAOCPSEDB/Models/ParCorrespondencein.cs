using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParCorrespondencein
{
    public int Partyid { get; set; }

    public int Correspondenceinno { get; set; }

    public int? Correspondenceinid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual CorCorrespondencein? Correspondencein { get; set; }

    public virtual ParParty Party { get; set; } = null!;
}
