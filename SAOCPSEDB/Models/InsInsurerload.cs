using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsInsurerload
{
    public int Insurerloadid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<InsBatch> InsBatches { get; set; } = new List<InsBatch>();

    public virtual ICollection<InsClaim> InsClaims { get; set; } = new List<InsClaim>();

    public virtual ICollection<InsEstimate> InsEstimates { get; set; } = new List<InsEstimate>();

    public virtual ICollection<InsFilenote> InsFilenotes { get; set; } = new List<InsFilenote>();

    public virtual ICollection<InsLiability> InsLiabilities { get; set; } = new List<InsLiability>();

    public virtual ICollection<InsMedcert> InsMedcerts { get; set; } = new List<InsMedcert>();

    public virtual ICollection<InsPayment> InsPayments { get; set; } = new List<InsPayment>();

    public virtual ICollection<InsRecovery> InsRecoveries { get; set; } = new List<InsRecovery>();

    public virtual ICollection<InsStatus> InsStatuses { get; set; } = new List<InsStatus>();

    public virtual ICollection<InsTimeoffwork> InsTimeoffworks { get; set; } = new List<InsTimeoffwork>();

    public virtual ICollection<InsWorkcapacity> InsWorkcapacities { get; set; } = new List<InsWorkcapacity>();
}
