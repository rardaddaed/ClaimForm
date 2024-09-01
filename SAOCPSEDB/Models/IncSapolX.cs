using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncSapolX
{
    public int Incidentid { get; set; }

    public string? Employeetype { get; set; }

    public string? Classification { get; set; }

    public string? Inclocation { get; set; }

    public string? Inclocationtype { get; set; }

    public string? Activity { get; set; }

    public string? Duties { get; set; }

    public string? Breach { get; set; }

    public string? Activityother { get; set; }

    public int? Involveoffender { get; set; }

    public int? Involvemental { get; set; }

    public int? Involvealcohol { get; set; }

    public int? Involvedrugs { get; set; }

    public int? Involveneedle { get; set; }

    public int? Involveanimal { get; set; }

    public int? Exposurefluid { get; set; }

    public int? Exposuredisease { get; set; }

    public int? Exposuresubstance { get; set; }

    public string? Exposuresource { get; set; }

    public DateTime? Exposuredob { get; set; }

    public int? Contributingfactor { get; set; }

    public string? Contributingfactortype { get; set; }

    public int? Polequipused { get; set; }

    public int? Polequipcaused { get; set; }

    public int? Polequipissue { get; set; }

    public int? Resultofmva { get; set; }

    public string? Resultofmvatype { get; set; }

    public int? Resultoffatigue { get; set; }

    public int? Duty { get; set; }

    public int? Majorevent { get; set; }

    public string? Majoreventdetails { get; set; }

    public int? Highrisk { get; set; }

    public int? Numofficerspresent { get; set; }

    public int? Clothingworn { get; set; }

    public string? Clothingidtype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<IncSapolequipcausedX> IncSapolequipcausedXes { get; set; } = new List<IncSapolequipcausedX>();

    public virtual ICollection<IncSapolequipusedX> IncSapolequipusedXes { get; set; } = new List<IncSapolequipusedX>();

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
