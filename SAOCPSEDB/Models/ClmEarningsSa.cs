using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmEarningsSa
{
    public int Claimid { get; set; }

    public int Earningsno { get; set; }

    public decimal? Baseweeklyearnings { get; set; }

    public decimal? Overtime { get; set; }

    public decimal? Shift { get; set; }

    public decimal? Nonpecuniary { get; set; }

    public decimal? Baseawardrate { get; set; }

    public decimal? Suitableduties { get; set; }

    public decimal? Hoursperweek { get; set; }

    public decimal? Otheremploymentbaseweeklyearn { get; set; }

    public decimal? Otheremploymentovertime { get; set; }

    public decimal? Otheremploymentshift { get; set; }

    public decimal? Otheremploymentnonpecuniary { get; set; }

    public decimal? Otheremploymentbaseawardrate { get; set; }

    public decimal? Otheremploymentsuitableduties { get; set; }

    public decimal? Otheremploymenthoursperweek { get; set; }

    public decimal? Hoursperweekallemployment { get; set; }

    public int? Daysperweek { get; set; }

    public short? Overridenweamount { get; set; }

    public decimal? Overriddennweamount { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public decimal? Penaltyrates { get; set; }

    public decimal? Otheremploymentpenaltyrates { get; set; }

    public decimal? Reductionofweeklypayment { get; set; }

    public virtual ClmEarning ClmEarning { get; set; } = null!;

    public virtual ClmEarningsSaX? ClmEarningsSaX { get; set; }
}
