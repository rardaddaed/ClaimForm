using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncCorrectiveactionX
{
    public int Incidentid { get; set; }

    public int Correctiveactionno { get; set; }

    public string? Consequence { get; set; }

    public string? Likelihood { get; set; }

    public string? Controltype { get; set; }

    public string? Description { get; set; }

    public int? Personresponsible { get; set; }

    public DateTime? Targetdate { get; set; }

    public DateTime? Completiondate { get; set; }

    public DateTime? Reviewdate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Completeddescription { get; set; }

    public int? Notifiedhrid { get; set; }

    public virtual IncActionplanX Incident { get; set; } = null!;

    public virtual IncHrdataX? PersonresponsibleNavigation { get; set; }
}
