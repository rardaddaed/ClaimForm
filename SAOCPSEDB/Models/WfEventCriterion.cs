using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WfEventCriterion
{
    public int Eventid { get; set; }

    public int? Jurisdictionzone { get; set; }

    public string? Filenotecategory { get; set; }

    public string? Documentsource { get; set; }

    public string? Documentcategory { get; set; }

    public string? Documenttype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Disputetype { get; set; }

    public string? Referraltype { get; set; }

    public string? Investigationtype { get; set; }

    public string? Roletype { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public virtual WfEvent Event { get; set; } = null!;
}
