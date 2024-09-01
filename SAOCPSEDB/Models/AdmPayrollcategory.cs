using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmPayrollcategory
{
    public int Payrollcategoryid { get; set; }

    public short? Active { get; set; }

    public DateTime? Dateeffective { get; set; }

    public string? Payrolldescriptioncodevalue { get; set; }

    public short? Jurisdictionzone { get; set; }

    public string? Earningscategorycodevalue { get; set; }

    public short? Includeinhours { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
