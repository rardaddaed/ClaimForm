using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SubReturnSa
{
    public int Returnid { get; set; }

    public int? Licenceid { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Datereturnfileloaded { get; set; }

    public int? Returnfileapplied { get; set; }

    public int? Errorsconfirmed { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual SaLicenceSa? Licence { get; set; }

    public virtual ICollection<SubReturnerrorSa> SubReturnerrorSas { get; set; } = new List<SubReturnerrorSa>();
}
