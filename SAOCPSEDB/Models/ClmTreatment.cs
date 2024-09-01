using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmTreatment
{
    public int Claimid { get; set; }

    public int Treatmentno { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public string? Referencenumber { get; set; }

    public short? Recommendedby { get; set; }

    public DateTime? Daterecommendationapproved { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public short? Noexpiry { get; set; }

    public int? Providerid { get; set; }

    public string? Paymentcategory { get; set; }

    public string? Paymenttype { get; set; }

    public int? Accountid { get; set; }

    public string? Notes { get; set; }

    public int? Servicesapproved { get; set; }

    public decimal? Amountapproved { get; set; }

    public int? Authorisedby { get; set; }

    public DateTime? Dateauthorised { get; set; }

    public short? Purchaseorder { get; set; }

    public DateTime? Statusdate { get; set; }

    public int? Statuschangeby { get; set; }

    public int? Servicesrequested { get; set; }

    public decimal? Amountrequested { get; set; }

    public int? Purchaseorderno { get; set; }

    public string? Status { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Itemcodes { get; set; }

    public virtual GlAccount? Account { get; set; }

    public virtual SecUser? AuthorisedbyNavigation { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmTreatmentdocument> ClmTreatmentdocuments { get; set; } = new List<ClmTreatmentdocument>();

    public virtual ICollection<ClmTreatmentitem> ClmTreatmentitems { get; set; } = new List<ClmTreatmentitem>();

    public virtual ICollection<ClmTreatmentstatushistory> ClmTreatmentstatushistories { get; set; } = new List<ClmTreatmentstatushistory>();

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual ParProvider? Provider { get; set; }

    public virtual SecUser? StatuschangebyNavigation { get; set; }
}
