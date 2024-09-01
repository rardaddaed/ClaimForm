using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class Zmappedcode
{
    public int Zone { get; set; }

    public string Mappingtype { get; set; } = null!;

    public string Codetype { get; set; } = null!;

    public string Codevalue { get; set; } = null!;

    public int? Mappedzone { get; set; }

    public string? Mappedcodetype { get; set; }

    public string? Mappedcodevalue { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual Zprimarycode? Zprimarycode { get; set; }

    public virtual Zprimarycode ZprimarycodeNavigation { get; set; } = null!;
}
