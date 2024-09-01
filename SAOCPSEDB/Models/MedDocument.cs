using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MedDocument
{
    public int Medcertid { get; set; }

    public int Documentno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual MedMedcert Medcert { get; set; } = null!;
}
