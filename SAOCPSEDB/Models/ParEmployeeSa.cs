using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParEmployeeSa
{
    public int Partyid { get; set; }

    public string? Countryofbirthcodetype { get; set; }

    public string? Countryofbirth { get; set; }

    public string? Languagecodetype { get; set; }

    public string? Language { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Niismember { get; set; }

    public virtual ParParty Party { get; set; } = null!;
}
