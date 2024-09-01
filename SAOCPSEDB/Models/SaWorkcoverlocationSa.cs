using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SaWorkcoverlocationSa
{
    public int Saworkcoverlocationid { get; set; }

    public string? Locationnumber { get; set; }

    public string? Locationname { get; set; }

    public short? Active { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<ClmempEmploymentSa> ClmempEmploymentSas { get; set; } = new List<ClmempEmploymentSa>();

    public virtual ICollection<SaRegistrationlocationSa> SaRegistrationlocationSas { get; set; } = new List<SaRegistrationlocationSa>();

    public virtual ICollection<SiteLicenceSa> SiteLicenceSas { get; set; } = new List<SiteLicenceSa>();
}
