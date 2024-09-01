using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GlLinkedcode
{
    public int Accountid { get; set; }

    public int Linkedcodeno { get; set; }

    public int? Jurisdictionzone { get; set; }

    public string? Codetype { get; set; }

    public string? Codevalue { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual GlAccount Account { get; set; } = null!;
}
