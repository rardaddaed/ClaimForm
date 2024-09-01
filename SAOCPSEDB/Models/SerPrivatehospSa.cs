using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SerPrivatehospSa
{
    public int Saprivatehospitalid { get; set; }

    public string? Item { get; set; }

    public DateTime? Datediscontinued { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<SerPrivatehospdescriptionSa> SerPrivatehospdescriptionSas { get; set; } = new List<SerPrivatehospdescriptionSa>();

    public virtual ICollection<SerPrivatehosprateSa> SerPrivatehosprateSas { get; set; } = new List<SerPrivatehosprateSa>();
}
