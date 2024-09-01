using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PolCoverage
{
    public int Policyid { get; set; }

    public int Coverageno { get; set; }

    public string? Coverageid { get; set; }

    public string? Coveragetype { get; set; }

    public DateTime? Datecoverageeffectivefrom { get; set; }

    public DateTime? Datecoverageeffectiveto { get; set; }

    public int? Active { get; set; }

    public string? Anzsic1993industrycode { get; set; }

    public string? Anzsic2006industrycode { get; set; }

    public decimal? Estimatedwages { get; set; }

    public int? Estimatednumberofworkers { get; set; }

    public decimal? Actualwages { get; set; }

    public int? Actualnumberofworkers { get; set; }

    public decimal? Initialdepositpremiumcharged { get; set; }

    public decimal? Currentadjusteddepositpremiumcharged { get; set; }

    public decimal? Actualfinalpremiumcharged { get; set; }

    public string? Premiumcollectiontype { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmLegalentity> ClmLegalentities { get; set; } = new List<ClmLegalentity>();

    public virtual PolPolicy Policy { get; set; } = null!;
}
