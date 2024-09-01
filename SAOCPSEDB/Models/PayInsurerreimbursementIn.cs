using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayInsurerreimbursementIn
{
    public int Paymentid { get; set; }

    public int? Paymentisreimbursed { get; set; }

    public DateTime? Datereimbursed { get; set; }

    public int? Reimbursementpaidinfull { get; set; }

    public decimal? Amountreimbursed { get; set; }

    public int? Notforreimbursement { get; set; }

    public string? Recieptnumber { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual PayPayment Payment { get; set; } = null!;
}
