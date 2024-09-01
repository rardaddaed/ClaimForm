using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmTaxscale
{
    public int Taxscaleid { get; set; }

    public string? Schedule { get; set; }

    public string? Financialyear { get; set; }

    public decimal? Earningsfrom { get; set; }

    public decimal? Earningsto { get; set; }

    public decimal? Coefficienta { get; set; }

    public decimal? Coefficientb { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;
}
