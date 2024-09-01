using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmIncident
{
    public int Claimid { get; set; }

    public DateTime? Dateofinjury { get; set; }

    public DateTime? Timeofinjury { get; set; }

    public int? Deemeddateofinjury { get; set; }

    public int? Workwasceased { get; set; }

    public string? Accidentlocationcodetype { get; set; }

    public string? Accidentlocation { get; set; }

    public string? Injuryoccurredplace { get; set; }

    public string? Injuryoccurredaddressline1 { get; set; }

    public string? Injuryoccurredaddressline2 { get; set; }

    public string? Injuryoccurredaddressline3 { get; set; }

    public string? Injuryoccurredsuburb { get; set; }

    public string? Injuryoccurredstate { get; set; }

    public string? Injuryoccurredpostcode { get; set; }

    public int? Injuryoccurredinternational { get; set; }

    public string? Injuryoccurredcountry { get; set; }

    public string? Dutystatuscodetype { get; set; }

    public string? Dutystatus { get; set; }

    public string? Descriptionofincident { get; set; }

    public string? Descriptionofinjury { get; set; }

    public string? Descriptionoftask { get; set; }

    public int? Incidentreportsubmitted { get; set; }

    public string? Incidentnumber { get; set; }

    public string? Incidentreportedto { get; set; }

    public string? Incidentreportedtophone { get; set; }

    public DateTime? Incidentreporteddate { get; set; }

    public DateTime? Incidentreportedtime { get; set; }

    public int? Admittedtohospital { get; set; }

    public int? Takentohospital { get; set; }

    public string? Nameofhospital { get; set; }

    public int? Deathcausedbyincident { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Wasincidentrelatedtocovid { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ClmIncidentX? ClmIncidentX { get; set; }
}
