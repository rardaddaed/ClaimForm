using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParBusinessdocument
{
    public int Partyid { get; set; }

    public int Businessdocumentno { get; set; }

    public int? Correspondenceinid { get; set; }

    public Guid? Portalcorrooutguid { get; set; }

    public DateTime? Dateprocessed { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual CorCorrespondencein? Correspondencein { get; set; }

    public virtual ParBusiness Party { get; set; } = null!;
}
