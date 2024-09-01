using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmGovsafetytextX
{
    public int Govsafetytextid { get; set; }

    public string Formtype { get; set; } = null!;

    public string Formgrouptype { get; set; } = null!;

    public string Contentname { get; set; } = null!;

    public string? Displayname { get; set; }

    public string? Conditionaltype { get; set; }

    public string? Conditionalvalue { get; set; }

    public string? Text { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
