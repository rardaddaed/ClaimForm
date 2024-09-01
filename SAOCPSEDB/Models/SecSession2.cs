using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecSession2
{
    public short Spid { get; set; }

    public int? Userid { get; set; }

    public string Token { get; set; } = null!;

    public DateTime? Starttime { get; set; }

    public short? Xbypassclaimsecurity { get; set; }

    public short? Xcanviewconfidentialclaim { get; set; }

    public short? Xsuspendsecurityupdates { get; set; }

    public short? Xbypassincidentsecurity { get; set; }

    public short? Xcanviewsiclaim { get; set; }

    public short? Xcanviewebclaim { get; set; }
}
