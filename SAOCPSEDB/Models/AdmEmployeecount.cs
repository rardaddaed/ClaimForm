using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmEmployeecount
{
    public int Employeecountid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public int? Orgstructid { get; set; }

    public int? Fulltimeemployees { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
