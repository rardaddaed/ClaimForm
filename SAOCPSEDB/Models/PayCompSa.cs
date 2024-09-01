using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayCompSa
{
    public int Paymentid { get; set; }

    public decimal? Thishourslost { get; set; }

    public decimal? Thishoursemployed { get; set; }

    public decimal? Thisnormalhoursperweek { get; set; }

    public decimal? Otherhourslost { get; set; }

    public decimal? Otherhoursemployed { get; set; }

    public decimal? Othernormalhoursperweek { get; set; }

    public int? Weeknumber { get; set; }

    public short? Seriousinjury { get; set; }

    public int? Impairmentpercentage { get; set; }

    public DateTime? Surgeryfromdate { get; set; }

    public decimal? Uncappednotionalweeklyearnings { get; set; }

    public short? Maxnweapplied { get; set; }

    public decimal? Maxnweamount { get; set; }

    public decimal? Cappednotionalweeklyearnings { get; set; }

    public decimal? Thisearnings { get; set; }

    public decimal? Otherearnings { get; set; }

    public decimal? Designatedearnings { get; set; }

    public int? Compensationrate { get; set; }

    public decimal? Calculatedamountpayable { get; set; }

    public decimal? Parttimeratio { get; set; }

    public short? Minimumwageapplied { get; set; }

    public decimal? Minimumwage { get; set; }

    public short? Topuprequired { get; set; }

    public decimal? Topupamount { get; set; }

    public decimal? Calculatededidayslost { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public decimal? Weeklyratio { get; set; }

    public decimal? Reductionofweeklypayment { get; set; }

    public virtual PayComp Payment { get; set; } = null!;
}
