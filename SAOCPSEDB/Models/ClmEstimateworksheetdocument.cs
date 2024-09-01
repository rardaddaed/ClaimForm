using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmEstimateworksheetdocument
{
    public int Claimid { get; set; }

    public int Estimateworksheetno { get; set; }

    public int Documentno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmEstimateworksheet ClmEstimateworksheet { get; set; } = null!;
}
