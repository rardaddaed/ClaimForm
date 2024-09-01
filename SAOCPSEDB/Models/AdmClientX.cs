using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmClientX
{
    public int Clientid { get; set; }

    public string? Clientnumber { get; set; }

    public string? Surname { get; set; }

    public string? Firstname { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public short? Gender { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Phone { get; set; }

    public string? Agegroup { get; set; }

    public string? Bed { get; set; }

    public string? Bedowner { get; set; }

    public string? Bedstatus { get; set; }

    public string? Teamdirectorate { get; set; }

    public string? Teamname { get; set; }

    public string? Costcentrenumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
