using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPiawemodifyhistory
{
    public int Claimid { get; set; }

    public int Piaweno { get; set; }

    public int Modifyno { get; set; }

    public DateTime? Datemodified { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmPiawe ClmPiawe { get; set; } = null!;

    public virtual SecUser? ModifiedbyNavigation { get; set; }
}
