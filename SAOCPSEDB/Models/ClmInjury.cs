using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmInjury
{
    public int Claimid { get; set; }

    public int Injuryno { get; set; }

    public int? Primaryinjury { get; set; }

    public string? Injuryside { get; set; }

    public string? Injuryseverity { get; set; }

    public string? Naturedescription { get; set; }

    public string? Nature1codetype { get; set; }

    public string? Nature1 { get; set; }

    public string? Nature2codetype { get; set; }

    public string? Nature2 { get; set; }

    public string? Bodilylocationdescription { get; set; }

    public string? Bodilylocation1codetype { get; set; }

    public string? Bodilylocation1 { get; set; }

    public string? Bodilylocation2codetype { get; set; }

    public string? Bodilylocation2 { get; set; }

    public string? Bodilylocation3codetype { get; set; }

    public string? Bodilylocation3 { get; set; }

    public string? Mechanismdescription { get; set; }

    public string? Mechanism1codetype { get; set; }

    public string? Mechanism1 { get; set; }

    public string? Mechanism2codetype { get; set; }

    public string? Mechanism2 { get; set; }

    public string? Breakdownagencydescription { get; set; }

    public string? Breakdownagency1codetype { get; set; }

    public string? Breakdownagency1 { get; set; }

    public string? Breakdownagency2codetype { get; set; }

    public string? Breakdownagency2 { get; set; }

    public string? Breakdownagency3codetype { get; set; }

    public string? Breakdownagency3 { get; set; }

    public string? Breakdownagency4codetype { get; set; }

    public string? Breakdownagency4 { get; set; }

    public string? Agencydescription { get; set; }

    public string? Agency1codetype { get; set; }

    public string? Agency1 { get; set; }

    public string? Agency2codetype { get; set; }

    public string? Agency2 { get; set; }

    public string? Agency3codetype { get; set; }

    public string? Agency3 { get; set; }

    public string? Agency4codetype { get; set; }

    public string? Agency4 { get; set; }

    public int? Agencysameasbreakdownagency { get; set; }

    public int? Recurringinjury { get; set; }

    public DateTime? Recurrencedate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmClaim1 Claim { get; set; } = null!;
}
