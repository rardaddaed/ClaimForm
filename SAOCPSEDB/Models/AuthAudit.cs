using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AuthAudit
{
    public int Authid { get; set; }

    public string? Type { get; set; }

    public string? Stage { get; set; }

    public string? Ip { get; set; }

    public string? Mac { get; set; }

    public string? Givenname { get; set; }

    public string? Familyname { get; set; }

    public string? Emailladdress { get; set; }

    public string? Portfolio { get; set; }

    public string? Region { get; set; }

    public string? Agency { get; set; }

    public DateTime? Dob { get; set; }

    public DateTime? Dateaudit { get; set; }

    public string? Error { get; set; }

    public short? Iswhsconsultant { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
