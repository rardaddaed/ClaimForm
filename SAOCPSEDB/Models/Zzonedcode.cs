using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Zzonedcode
{
    public int Zone { get; set; }

    public string Codetype { get; set; } = null!;

    public string Codevalue { get; set; } = null!;

    public string? Displayvalue { get; set; }

    public int? Userflag { get; set; }

    public string? Userfield { get; set; }

    public string? Aggregatetype { get; set; }

    public string? Aggregatevalue { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public byte[]? Sourcetimestamp { get; set; }

    public Guid? Sourceguid { get; set; }
}
