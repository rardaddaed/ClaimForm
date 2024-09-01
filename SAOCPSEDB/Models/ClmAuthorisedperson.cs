using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmAuthorisedperson
{
    public int Claimid { get; set; }

    public string? Role { get; set; }

    public string? Familyname { get; set; }

    public string? Givenname { get; set; }

    public string? Phone { get; set; }

    public string? Mobilephone { get; set; }

    public string? Email { get; set; }

    public string? Addressline1 { get; set; }

    public string? Addressline2 { get; set; }

    public string? Addressline3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? International { get; set; }

    public string? Country { get; set; }

    public string? Comments { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmAuthorisedpersondocument> ClmAuthorisedpersondocuments { get; set; } = new List<ClmAuthorisedpersondocument>();
}
