using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParBusiness
{
    public int Partyid { get; set; }

    public string? Status { get; set; }

    public DateTime? Statuschangeddatetime { get; set; }

    public DateTime? Invitesentdatetime { get; set; }

    public DateTime? Inviteaccepteddatetime { get; set; }

    public DateTime? Lastsynchroniseddatetime { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Allowedtoviewclient { get; set; }

    public Guid? Portalguid { get; set; }

    public virtual ICollection<ParBusinessdocument> ParBusinessdocuments { get; set; } = new List<ParBusinessdocument>();

    public virtual ICollection<ParBusinesspermission> ParBusinesspermissions { get; set; } = new List<ParBusinesspermission>();

    public virtual ICollection<ParBusinessprovider> ParBusinessproviders { get; set; } = new List<ParBusinessprovider>();

    public virtual ParParty Party { get; set; } = null!;
}
