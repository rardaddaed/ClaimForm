using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParProvider
{
    public int Partyid { get; set; }

    public string? Vendornumber { get; set; }

    public string? Specialrequirements { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmPermimpairSa> ClmPermimpairSas { get; set; } = new List<ClmPermimpairSa>();

    public virtual ICollection<ClmTreatment> ClmTreatments { get; set; } = new List<ClmTreatment>();

    public virtual ICollection<ParBusinessprovider> ParBusinessproviders { get; set; } = new List<ParBusinessprovider>();

    public virtual ICollection<ParProvidernumber> ParProvidernumbers { get; set; } = new List<ParProvidernumber>();

    public virtual ParParty Party { get; set; } = null!;
}
