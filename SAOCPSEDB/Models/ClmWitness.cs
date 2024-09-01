using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmWitness
{
    public int Claimid { get; set; }

    public int Witnessno { get; set; }

    public string? Persontype { get; set; }

    public string? Familyname { get; set; }

    public string? Givennames { get; set; }

    public string? Addressline1 { get; set; }

    public string? Addressline2 { get; set; }

    public string? Addressline3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? International { get; set; }

    public string? Country { get; set; }

    public string? Comments { get; set; }

    public int? Statementprovided { get; set; }

    public int? Documentid { get; set; }

    public string? Phone { get; set; }

    public string? Mobilephone { get; set; }

    public string? Email { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }
}
