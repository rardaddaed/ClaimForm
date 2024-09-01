using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmClaim
{
    public int Claimid { get; set; }

    public string? Claimnumber { get; set; }

    public int? Jurisdictionzone { get; set; }

    public int? State { get; set; }

    public string? Claimtype { get; set; }

    public string? Claimclassification { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Datereceivedemployer { get; set; }

    public DateTime? Datereceivedinsurer { get; set; }

    public DateTime? Datesignedemployee { get; set; }

    public DateTime? Datesignedemployer { get; set; }

    public DateTime? Dateinsurernotifiedofclaim { get; set; }

    public DateTime? Dateinsurernotifiedofinjury { get; set; }

    public int? Claimisconfidential { get; set; }

    public int? Convertedfromclaimid { get; set; }

    public DateTime? Dateclaimconverted { get; set; }

    public int? Convertedby { get; set; }

    public int? Potentialcommonlaw { get; set; }

    public int? Potentialrecovery { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
