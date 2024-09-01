using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ExampleKinga
{
    public int Pkid { get; set; }

    public string? Somedata { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
