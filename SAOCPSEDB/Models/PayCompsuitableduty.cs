using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayCompsuitableduty
{
    public int Paymentid { get; set; }

    public int Compsuitabledutiesno { get; set; }

    public DateTime? Compensationdate { get; set; }

    public int? Fullshiftslost { get; set; }

    public decimal? Hourslost { get; set; }

    public decimal? Hoursemployed { get; set; }

    public decimal? Otherleavehours { get; set; }

    public decimal? Earnings { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual PayPayment Payment { get; set; } = null!;
}
