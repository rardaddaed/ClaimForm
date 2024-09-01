using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParLocation
{
    public int Partyid { get; set; }

    public int Locationno { get; set; }

    public int? Active { get; set; }

    public int? Streetsameaspostal { get; set; }

    public string? Streetaddressline1 { get; set; }

    public string? Streetaddressline2 { get; set; }

    public string? Streetaddressline3 { get; set; }

    public string? Streetsuburb { get; set; }

    public string? Streetstate { get; set; }

    public string? Streetpostcode { get; set; }

    public int? Streetinternational { get; set; }

    public string? Streetcountry { get; set; }

    public int? Postalsameasstreet { get; set; }

    public string? Postaladdressline1 { get; set; }

    public string? Postaladdressline2 { get; set; }

    public string? Postaladdressline3 { get; set; }

    public string? Postalsuburb { get; set; }

    public string? Postalstate { get; set; }

    public string? Postalpostcode { get; set; }

    public int? Postalinternational { get; set; }

    public string? Postalcountry { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmCompensationrecipient> ClmCompensationrecipients { get; set; } = new List<ClmCompensationrecipient>();

    public virtual ICollection<ClmDependant> ClmDependants { get; set; } = new List<ClmDependant>();

    public virtual ICollection<ClmLegalrep> ClmLegalreps { get; set; } = new List<ClmLegalrep>();

    public virtual ICollection<ClmNominateddoctor> ClmNominateddoctors { get; set; } = new List<ClmNominateddoctor>();

    public virtual ICollection<ClmProvider> ClmProviders { get; set; } = new List<ClmProvider>();

    public virtual ICollection<ClmPurchaseorder> ClmPurchaseorderParLocationNavigations { get; set; } = new List<ClmPurchaseorder>();

    public virtual ICollection<ClmPurchaseorder> ClmPurchaseorderParLocations { get; set; } = new List<ClmPurchaseorder>();

    public virtual ICollection<GlTransaction> GlTransactions { get; set; } = new List<GlTransaction>();

    public virtual ICollection<MedMedcert> MedMedcerts { get; set; } = new List<MedMedcert>();

    public virtual ICollection<ParBank> ParBanks { get; set; } = new List<ParBank>();

    public virtual ICollection<ParContact> ParContacts { get; set; } = new List<ParContact>();

    public virtual ICollection<ParLocationhistory> ParLocationhistories { get; set; } = new List<ParLocationhistory>();

    public virtual ParParty Party { get; set; } = null!;

    public virtual ICollection<PayCompensationrecipient> PayCompensationrecipients { get; set; } = new List<PayCompensationrecipient>();

    public virtual ICollection<PayPayee> PayPayees { get; set; } = new List<PayPayee>();

    public virtual ICollection<RecRecovery> RecRecoveries { get; set; } = new List<RecRecovery>();
}
