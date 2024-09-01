using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmAuthorisationlevel
{
    public int Authorisationlevelid { get; set; }

    public int? Positionid { get; set; }

    public int? Jurisdictionzone { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Claimtype { get; set; }

    public virtual SecPosition? Position { get; set; }
}
