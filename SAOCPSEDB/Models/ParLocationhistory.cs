using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParLocationhistory
{
    public int Partyid { get; set; }

    public int Locationno { get; set; }

    public int Locationhistoryno { get; set; }

    public short? Addresstype { get; set; }

    public DateTime? Datechanged { get; set; }

    public string? Addressline1 { get; set; }

    public string? Addressline2 { get; set; }

    public string? Addressline3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? International { get; set; }

    public string? Country { get; set; }

    public int? Changedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser? ChangedbyNavigation { get; set; }

    public virtual ParLocation ParLocation { get; set; } = null!;
}
