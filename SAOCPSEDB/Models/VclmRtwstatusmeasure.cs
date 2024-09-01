using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class VclmRtwstatusmeasure
{
    public int Claimid { get; set; }

    public DateTime? Rtwdate4week { get; set; }

    public string? Rtwstatus4week { get; set; }

    public DateTime? Rtwdate13week { get; set; }

    public string? Rtwstatus13week { get; set; }

    public DateTime? Rtwdate26week { get; set; }

    public string? Rtwstatus26week { get; set; }

    public DateTime? Rtwdate52week { get; set; }

    public string? Rtwstatus52week { get; set; }

    public DateTime? Rtwdate78week { get; set; }

    public string? Rtwstatus78week { get; set; }

    public DateTime? Rtwdate103week { get; set; }

    public string? Rtwstatus103week { get; set; }
}
