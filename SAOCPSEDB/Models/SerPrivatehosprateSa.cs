using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerPrivatehosprateSa
{
    public int Saprivatehospitalid { get; set; }

    public int Saprivatehospitalrateid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public decimal? Maxfee { get; set; }

    public int? Uppertrimpointdays { get; set; }

    public int? Lowertrimpointdays { get; set; }

    public decimal? Maxperdayrate { get; set; }

    public string? Type { get; set; }

    public int? Servicerateid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SerPrivatehospSa Saprivatehospital { get; set; } = null!;

    public virtual SerRate? Servicerate { get; set; }
}
