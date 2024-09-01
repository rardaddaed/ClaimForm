using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PorInjuredworkerassociateddocumentX
{
    public int Injuredworkerid { get; set; }

    public int Injuredworkerassociateddocumentno { get; set; }

    public string? Documentcategory { get; set; }

    public string? Documenttype { get; set; }

    public string? Description { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual PorInjuredworkerX Injuredworker { get; set; } = null!;
}
