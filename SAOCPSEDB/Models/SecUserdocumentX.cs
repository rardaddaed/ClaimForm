using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecUserdocumentX
{
    public int Userid { get; set; }

    public int Userdocumentno { get; set; }

    public string? Documentcategory { get; set; }

    public string? Documenttype { get; set; }

    public string? Description { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual DmsDocument? Document { get; set; }

    public virtual SecUser User { get; set; } = null!;
}
