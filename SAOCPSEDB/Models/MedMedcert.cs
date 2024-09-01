using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MedMedcert
{
    public int Medcertid { get; set; }

    public string? Certificatetypecodetype { get; set; }

    public string? Certificatetype { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Dateexamined { get; set; }

    public DateTime? Timeexamined { get; set; }

    public DateTime? Datereceived { get; set; }

    public DateTime? Reviewdate { get; set; }

    public string? Stage { get; set; }

    public string? Diagnosis { get; set; }

    public string? Comments { get; set; }

    public int? Consistantdescription { get; set; }

    public int? Providerpartyid { get; set; }

    public int? Providerlocationno { get; set; }

    public int? Providercontactno { get; set; }

    public DateTime? Dateprovidersigned { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public DateTime? Timeentered { get; set; }

    public string? Manualprovidername { get; set; }

    public virtual ICollection<ClmMedcert> ClmMedcerts { get; set; } = new List<ClmMedcert>();

    public virtual ICollection<EmlinMedcert> EmlinMedcerts { get; set; } = new List<EmlinMedcert>();

    public virtual ICollection<MedCapacity> MedCapacities { get; set; } = new List<MedCapacity>();

    public virtual ICollection<MedDocument> MedDocuments { get; set; } = new List<MedDocument>();

    public virtual MedMedcertSa? MedMedcertSa { get; set; }

    public virtual ParContact? ParContact { get; set; }

    public virtual ParLocation? ParLocation { get; set; }

    public virtual ParParty? Providerparty { get; set; }
}
