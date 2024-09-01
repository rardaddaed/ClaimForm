using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPiawehistory
{
    public int Claimid { get; set; }

    public int Piaweno { get; set; }

    public decimal Piawehistoryno { get; set; }

    public short? Selected { get; set; }

    public DateTime? Datepaid { get; set; }

    public string? Payrollcode { get; set; }

    public string? Payrolldescription { get; set; }

    public string? Earningscategory { get; set; }

    public decimal? Hoursworked { get; set; }

    public decimal? Amountpaid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Includeinhours { get; set; }

    public DateTime? Datefrom { get; set; }

    public DateTime? Dateto { get; set; }

    public string? Reason { get; set; }

    public virtual ClmPiawe ClmPiawe { get; set; } = null!;
}
