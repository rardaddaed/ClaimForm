using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RptDocument
{
    public int Reportid { get; set; }

    public int Documentno { get; set; }

    public int? Jobid { get; set; }

    public int? Recipientno { get; set; }

    public DateTime? Documentgenerateddatetime { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Jobqueueid { get; set; }

    public virtual DmsDocument? Document { get; set; }

    public virtual JobRecipient? JobRecipient { get; set; }

    public virtual RptReport Report { get; set; } = null!;

    public virtual RptDocumentX? RptDocumentX { get; set; }
}
