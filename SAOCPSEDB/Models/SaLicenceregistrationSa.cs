using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SaLicenceregistrationSa
{
    public int Salicenceid { get; set; }

    public int Saregistrationid { get; set; }

    public DateTime? Datelinked { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SaLicenceSa Salicence { get; set; } = null!;

    public virtual SaRegistrationSa Saregistration { get; set; } = null!;
}
