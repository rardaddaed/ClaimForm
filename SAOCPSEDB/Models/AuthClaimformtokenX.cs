using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AuthClaimformtokenX
{
    public int Tokenid { get; set; }

    public string? Email { get; set; }

    public DateTime? Datetimegenerated { get; set; }

    public DateTime? Datetimeverified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
