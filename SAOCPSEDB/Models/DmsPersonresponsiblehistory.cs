using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class DmsPersonresponsiblehistory
{
    public int Documentid { get; set; }

    public int Personresphistoryno { get; set; }

    public int? Personrespno { get; set; }

    public int? Userid { get; set; }

    public DateTime? Datetimechanged { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual DmsDocument Document { get; set; } = null!;
}
