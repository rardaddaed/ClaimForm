using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPayroll
{
    public int Claimid { get; set; }

    public string? Salaryclass { get; set; }

    public string? Payrollcode { get; set; }

    public string? Payfrequency { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Payrolldayofweek { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
