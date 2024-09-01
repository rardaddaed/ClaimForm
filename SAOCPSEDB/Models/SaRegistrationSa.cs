using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SaRegistrationSa
{
    public int Saregistrationid { get; set; }

    public string? Registrationnumber { get; set; }

    public string? Companyname { get; set; }

    public short? Active { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Notes { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Contact { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<ClmempEmploymentSa> ClmempEmploymentSas { get; set; } = new List<ClmempEmploymentSa>();

    public virtual ICollection<SaLicenceregistrationSa> SaLicenceregistrationSas { get; set; } = new List<SaLicenceregistrationSa>();

    public virtual ICollection<SaRegistrationSaX> SaRegistrationSaXes { get; set; } = new List<SaRegistrationSaX>();

    public virtual ICollection<SaRegistrationlocationSa> SaRegistrationlocationSas { get; set; } = new List<SaRegistrationlocationSa>();

    public virtual ICollection<SiteLicenceSa> SiteLicenceSas { get; set; } = new List<SiteLicenceSa>();
}
