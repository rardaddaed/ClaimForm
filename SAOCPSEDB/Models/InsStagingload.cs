using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsStagingload
{
    public int Stagingloadid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<InsBatch> InsBatches { get; set; } = new List<InsBatch>();

    public virtual ICollection<InsClaimstaging> InsClaimstagings { get; set; } = new List<InsClaimstaging>();

    public virtual ICollection<InsEstimatestaging> InsEstimatestagings { get; set; } = new List<InsEstimatestaging>();

    public virtual ICollection<InsFilenotestaging> InsFilenotestagings { get; set; } = new List<InsFilenotestaging>();

    public virtual ICollection<InsLiabilitystaging> InsLiabilitystagings { get; set; } = new List<InsLiabilitystaging>();

    public virtual ICollection<InsMedcertstaging> InsMedcertstagings { get; set; } = new List<InsMedcertstaging>();

    public virtual ICollection<InsPaymentstaging> InsPaymentstagings { get; set; } = new List<InsPaymentstaging>();

    public virtual ICollection<InsRecoverystaging> InsRecoverystagings { get; set; } = new List<InsRecoverystaging>();

    public virtual ICollection<InsStatusstaging> InsStatusstagings { get; set; } = new List<InsStatusstaging>();

    public virtual ICollection<InsTimeoffworkstaging> InsTimeoffworkstagings { get; set; } = new List<InsTimeoffworkstaging>();

    public virtual ICollection<InsWorkcapacitystaging> InsWorkcapacitystagings { get; set; } = new List<InsWorkcapacitystaging>();
}
