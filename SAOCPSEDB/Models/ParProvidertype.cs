using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParProvidertype
{
    public int Partyid { get; set; }

    public int Providertypeno { get; set; }

    public string? Providertype { get; set; }

    public int? Primaryprovidertype { get; set; }

    public DateTime? Dateeffectivefrom { get; set; }

    public DateTime? Dateeffectiveto { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ParProvidertypenumber> ParProvidertypenumbers { get; set; } = new List<ParProvidertypenumber>();

    public virtual ParParty Party { get; set; } = null!;
}
