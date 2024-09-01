using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PayComp
{
    public int Paymentid { get; set; }

    public DateTime? Compensationfromdate { get; set; }

    public DateTime? Compensationtodate { get; set; }

    public int? Compensationweeks { get; set; }

    public int? Compensationdays { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public string? Compensationtype { get; set; }

    public int? Normaldaysperweek { get; set; }

    public decimal? Normalhoursperweek { get; set; }

    public int? Rostereddaysinperiod { get; set; }

    public int? Dayslost { get; set; }

    public decimal? Hourslost { get; set; }

    public int? Fullshiftslost { get; set; }

    public decimal? Calculatedcomppayable { get; set; }

    public short? Overridecalculation { get; set; }

    public decimal? Overridingamount { get; set; }

    public decimal? Totalamountpayable { get; set; }

    public decimal? Paygwithheldamount { get; set; }

    public short? Recurringpayment { get; set; }

    public DateTime? Recurringfromdate { get; set; }

    public int? Recurringweeks { get; set; }

    public short? Recurringauthorised { get; set; }

    public DateTime? Recurringdateauthorised { get; set; }

    public int? Recurringauthorisedbyid { get; set; }

    public short? Recurringpreauthorised { get; set; }

    public int? Recurringpaymentid { get; set; }

    public short? Recurrencecomplete { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public int? Applysuitabledutieshours { get; set; }

    public int? Financialyearending { get; set; }

    public DateTime? Datefinancialyearupdated { get; set; }

    public DateTime? Daterecurrencescompleted { get; set; }

    public int? Recurrentpaymentsterminatedbyid { get; set; }

    public virtual ICollection<PayComp> InverseRecurringpaymentNavigation { get; set; } = new List<PayComp>();

    public virtual PayCompSa? PayCompSa { get; set; }

    public virtual PayPayment Payment { get; set; } = null!;

    public virtual PayComp? RecurringpaymentNavigation { get; set; }
}
