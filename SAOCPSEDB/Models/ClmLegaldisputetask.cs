using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmLegaldisputetask
{
    public int Claimid { get; set; }

    public int Legalno { get; set; }

    public int Taskno { get; set; }

    public string? Tasktype { get; set; }

    public string? Responsibilityof { get; set; }

    public string? Description { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Timeentered { get; set; }

    public short? Assignaction { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? Reminderdate { get; set; }

    public DateTime? Datecompleted { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmLegaldispute ClmLegaldispute { get; set; } = null!;

    public virtual ICollection<ClmLegaldisputetaskresp> ClmLegaldisputetaskresps { get; set; } = new List<ClmLegaldisputetaskresp>();

    public virtual DmsDocument? Document { get; set; }

    public virtual SecUser? EnteredbyNavigation { get; set; }
}
