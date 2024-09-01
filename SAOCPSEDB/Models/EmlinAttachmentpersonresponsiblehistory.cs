using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EmlinAttachmentpersonresponsiblehistory
{
    public int Emailid { get; set; }

    public int Attachno { get; set; }

    public int Historyno { get; set; }

    public int? Personresponsible { get; set; }

    public DateTime? Dateassigned { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EmlinAttachment EmlinAttachment { get; set; } = null!;

    public virtual SecUser? PersonresponsibleNavigation { get; set; }
}
