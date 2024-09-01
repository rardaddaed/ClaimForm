using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayCompensationrecipient
{
    public int Paymentid { get; set; }

    public int Compensationrecipientno { get; set; }

    public int? Priority { get; set; }

    public DateTime? Datefrom { get; set; }

    public DateTime? Dateto { get; set; }

    public string? Recipienttype { get; set; }

    public int? Partyid { get; set; }

    public int? Locationno { get; set; }

    public int? Contactno { get; set; }

    public decimal? Percentageperpayment { get; set; }

    public decimal? Amountperpayment { get; set; }

    public decimal? Maxamountperpayment { get; set; }

    public decimal? Maxamountperclaim { get; set; }

    public string? Recipientreference { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ParContact? ParContact { get; set; }

    public virtual ParLocation? ParLocation { get; set; }

    public virtual ParParty? Party { get; set; }

    public virtual PayPayment Payment { get; set; } = null!;
}
