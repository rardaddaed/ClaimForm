using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPermimpairinjurySa
{
    public int Claimid { get; set; }

    public int Sapermimpairno { get; set; }

    public int Assessedinjuryno { get; set; }

    public string? Bodilylocation2codetype { get; set; }

    public string? Bodilylocation2 { get; set; }

    public string? Workcoverguidelines { get; set; }

    public string? Ama5 { get; set; }

    public decimal? Wholepersonimpairment { get; set; }

    public decimal? Preexistingimpairment { get; set; }

    public decimal? Compensableimpairment { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Bodypartsassessed { get; set; }

    public virtual ClmPermimpairSa ClmPermimpairSa { get; set; } = null!;
}
