﻿using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AuthAuthEmaildomain
{
    public int Emaildomainid { get; set; }

    public string? Domain { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
