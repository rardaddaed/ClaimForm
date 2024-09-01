using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RehRehab
{
    public int Rehabid { get; set; }

    public string? Rehabtypecodetype { get; set; }

    public string? Rehabtype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmRehab> ClmRehabs { get; set; } = new List<ClmRehab>();

    public virtual ICollection<EmlinRehab> EmlinRehabs { get; set; } = new List<EmlinRehab>();

    public virtual ICollection<RehActionX> RehActionXes { get; set; } = new List<RehActionX>();

    public virtual ICollection<RehDocument> RehDocuments { get; set; } = new List<RehDocument>();

    public virtual ICollection<RehGoalX> RehGoalXes { get; set; } = new List<RehGoalX>();

    public virtual RehRehabX? RehRehabX { get; set; }

    public virtual ICollection<RehSdrosterX> RehSdrosterXes { get; set; } = new List<RehSdrosterX>();
}
