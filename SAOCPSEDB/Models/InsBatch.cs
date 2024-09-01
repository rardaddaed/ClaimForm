using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsBatch
{
    public int Insbatchid { get; set; }

    public int? Insurerid { get; set; }

    public DateTime? Dateofload { get; set; }

    public DateTime? Dateoffile { get; set; }

    public int? Stagingloadid { get; set; }

    public int? Insurerloadid { get; set; }

    public int? Initialload { get; set; }

    public int? Unlinkedload { get; set; }

    public int? Unlinkedloadforinsurerloadid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsInsurer? Insurer { get; set; }

    public virtual InsInsurerload? Insurerload { get; set; }

    public virtual InsStagingload? Stagingload { get; set; }
}
