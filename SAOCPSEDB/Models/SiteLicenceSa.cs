using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SiteLicenceSa
{
    public int Siteid { get; set; }

    public int Licenceno { get; set; }

    public int? Salicenceid { get; set; }

    public int? Saregistrationid { get; set; }

    public int? Saworkcoverlocationid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SaLicenceSa? Salicence { get; set; }

    public virtual SaRegistrationSa? Saregistration { get; set; }

    public virtual SaWorkcoverlocationSa? Saworkcoverlocation { get; set; }

    public virtual SiteSite Site { get; set; } = null!;
}
