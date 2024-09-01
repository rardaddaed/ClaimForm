using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class CorIndocument
{
    public int Correspondenceinid { get; set; }

    public int Indocumentno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual CorCorrespondencein Correspondencein { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }
}
