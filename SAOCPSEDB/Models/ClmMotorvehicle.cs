using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmMotorvehicle
{
    public int Claimid { get; set; }

    public int Motorvehiclenno { get; set; }

    public string? Vehicle1drivername { get; set; }

    public string? Vehicle1registrationnumber { get; set; }

    public int? Vehicle1registrationstate { get; set; }

    public string? Vehicle2drivername { get; set; }

    public string? Vehicle2registrationnumber { get; set; }

    public int? Vehicle2registrationstate { get; set; }

    public int? Ctppotentialrecovery { get; set; }

    public string? Ctpreferencenumber { get; set; }

    public DateTime? Ctpreferraldate { get; set; }

    public int? Liabilityacceptedbyemployer { get; set; }

    public int? Driveratfault { get; set; }

    public int? Policereportobtained { get; set; }

    public string? Policereportnumber { get; set; }

    public string? Policestation { get; set; }

    public string? Comments { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }
}
