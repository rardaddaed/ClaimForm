using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecUserpositionCommon
{
    public int Userid { get; set; }

    public int Positionno { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Datemodified { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual SecUser? ModifiedbyNavigation { get; set; }

    public virtual SecUserposition SecUserposition { get; set; } = null!;
}
