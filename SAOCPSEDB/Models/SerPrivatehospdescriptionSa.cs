using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerPrivatehospdescriptionSa
{
    public int Saprivatehospitalid { get; set; }

    public int Saprivatehospitaldescriptionid { get; set; }

    public DateTime? Dateeffective { get; set; }

    public string? Description { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SerPrivatehospSa Saprivatehospital { get; set; } = null!;
}
