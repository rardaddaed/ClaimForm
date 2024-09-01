using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmNominateddoctor
{
    public int Claimid { get; set; }

    public int Nominateddoctorno { get; set; }

    public int? Nominateddoctorpartyid { get; set; }

    public int? Nominateddoctorlocationno { get; set; }

    public int? Nominateddoctorcontactno { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ParParty? Nominateddoctorparty { get; set; }

    public virtual ParContact? ParContact { get; set; }

    public virtual ParLocation? ParLocation { get; set; }
}
