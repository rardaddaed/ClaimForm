using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SaLicenceSa
{
    public int Salicenceid { get; set; }

    public string? Licencenumber { get; set; }

    public string? Entityname { get; set; }

    public short? Active { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Mailboxnumber { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<ClmempEmploymentSa> ClmempEmploymentSas { get; set; } = new List<ClmempEmploymentSa>();

    public virtual ICollection<SaLicenceregistrationSa> SaLicenceregistrationSas { get; set; } = new List<SaLicenceregistrationSa>();

    public virtual ICollection<SiteLicenceSa> SiteLicenceSas { get; set; } = new List<SiteLicenceSa>();

    public virtual ICollection<SubReturnSa> SubReturnSas { get; set; } = new List<SubReturnSa>();
}
