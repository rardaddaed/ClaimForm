using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmLegaldisputerep
{
    public int Claimid { get; set; }

    public int Legalno { get; set; }

    public int Legalrepresentativeno { get; set; }

    public string? Representing { get; set; }

    public string? Representativetype { get; set; }

    public int? Partyid { get; set; }

    public int? Locationno { get; set; }

    public short? Dxaddress { get; set; }

    public short? Addressforservice { get; set; }

    public string? Preferredcontactmethod { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ClmLegaldispute ClmLegaldispute { get; set; } = null!;
}
