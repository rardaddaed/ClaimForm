using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EmlAddress
{
    public int Emailid { get; set; }

    public int Addressno { get; set; }

    public string? Type { get; set; }

    public string? Recipientname { get; set; }

    public string? Emailto { get; set; }

    public string? Emailfrom { get; set; }

    public int? Recipienttype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual EmlEmail Email { get; set; } = null!;
}
