using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParContact
{
    public int Partyid { get; set; }

    public int Locationno { get; set; }

    public int Contactno { get; set; }

    public string? Contacttype { get; set; }

    public string? Contactname { get; set; }

    public string? Phone { get; set; }

    public string? Workphone { get; set; }

    public string? Mobilephone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public int? Primarycontact { get; set; }

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

    public virtual ICollection<MedMedcert> MedMedcerts { get; set; } = new List<MedMedcert>();

    public virtual ICollection<ParContacthistory> ParContacthistories { get; set; } = new List<ParContacthistory>();

    public virtual ParLocation ParLocation { get; set; } = null!;

    public virtual ParParty Party { get; set; } = null!;

    public virtual ICollection<PayCompensationrecipient> PayCompensationrecipients { get; set; } = new List<PayCompensationrecipient>();
}
