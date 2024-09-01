﻿using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmTreatmentitem
{
    public int Claimid { get; set; }

    public int Treatmentno { get; set; }

    public int Treatmentitemno { get; set; }

    public int? Paymentid { get; set; }

    public int? Itemno { get; set; }

    public decimal? Matchedamount { get; set; }

    public int? Matchedservices { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmTreatment ClmTreatment { get; set; } = null!;

    public virtual PayItem? PayItem { get; set; }
}
