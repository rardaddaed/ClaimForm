using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmLegaldispute
{
    public int Claimid { get; set; }

    public int Legalno { get; set; }

    public string? Disputetype { get; set; }

    public string? Status { get; set; }

    public string? Courttribunal { get; set; }

    public string? Matterfilenumber { get; set; }

    public string? Partylodgedby { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Datelodged { get; set; }

    public DateTime? Dateacknowledged { get; set; }

    public DateTime? Datereferredtolegal { get; set; }

    public string? Detailsofdispute { get; set; }

    public string? Finaloutcome { get; set; }

    public DateTime? Finaloutcomedate { get; set; }

    public string? Outcomecomments { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public decimal? Settlementamount { get; set; }

    public int? Permimpairpercentclaimed { get; set; }

    public decimal? Permimpairamountclaimed { get; set; }

    public decimal? Settlementpercent { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmLegaldisputeevent> ClmLegaldisputeevents { get; set; } = new List<ClmLegaldisputeevent>();

    public virtual ICollection<ClmLegaldisputerep> ClmLegaldisputereps { get; set; } = new List<ClmLegaldisputerep>();

    public virtual ICollection<ClmLegaldisputetask> ClmLegaldisputetasks { get; set; } = new List<ClmLegaldisputetask>();
}
