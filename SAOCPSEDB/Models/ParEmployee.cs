using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParEmployee
{
    public int Partyid { get; set; }

    public string? Employeenumber { get; set; }

    public DateTime? Employmentstartdate { get; set; }

    public int? Exemployee { get; set; }

    public DateTime? Employmentenddate { get; set; }

    public string? Employmentendreason { get; set; }

    public int? Overridehr { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Deceased { get; set; }

    public DateTime? Datedeceased { get; set; }

    public virtual ICollection<ClmInjuredworker> ClmInjuredworkers { get; set; } = new List<ClmInjuredworker>();

    public virtual ICollection<HrDatum> HrData { get; set; } = new List<HrDatum>();

    public virtual ParEmployeeX? ParEmployeeX { get; set; }

    public virtual ParParty Party { get; set; } = null!;
}
