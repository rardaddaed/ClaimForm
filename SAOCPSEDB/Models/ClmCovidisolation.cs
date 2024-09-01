using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmCovidisolation
{
    public int Claimid { get; set; }

    public int Covidisolationno { get; set; }

    public int? Workingfromhome { get; set; }

    public string? Typeofinjury { get; set; }

    public DateTime? Dateofexposure { get; set; }

    public string? Typeofexposure { get; set; }

    public int? Testedforcovid { get; set; }

    public DateTime? Datetestcompleted { get; set; }

    public DateTime? Dateoftestconfirmation { get; set; }

    public string? Comfirmationresult { get; set; }

    public int? Hospitalised { get; set; }

    public string? Isolationtype { get; set; }

    public DateTime? Dateisolatedfrom { get; set; }

    public DateTime? Dateisolatedto { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmCovidsymptom> ClmCovidsymptoms { get; set; } = new List<ClmCovidsymptom>();
}
