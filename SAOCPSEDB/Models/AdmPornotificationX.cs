using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmPornotificationX
{
    public int Pornotificationid { get; set; }

    public string? Shorttitle { get; set; }

    public string? Triggeringevent { get; set; }

    public short? Active { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public short? Includepdfreport { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<AdmPornotificationemailX> AdmPornotificationemailXes { get; set; } = new List<AdmPornotificationemailX>();

    public virtual ICollection<AdmPornotificationroleX> AdmPornotificationroleXes { get; set; } = new List<AdmPornotificationroleX>();
}
