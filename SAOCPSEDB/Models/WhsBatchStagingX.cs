using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class WhsBatchStagingX
{
    public int Batchid { get; set; }

    public int Rownumber { get; set; }

    public int? Invalid { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentDateTime { get; set; }

    public string? IncidentDescription { get; set; }

    public string? InjuryIllnessDescription { get; set; }

    public DateTime? DateReported { get; set; }

    public string? ReportedToName { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? InitialTreatmentType { get; set; }

    public string? InjuryType { get; set; }

    public string? Entity { get; set; }

    public string? Level1 { get; set; }

    public string? Level2 { get; set; }

    public string? Level3 { get; set; }

    public string? Level4 { get; set; }

    public string? Level5 { get; set; }

    public string? Level6 { get; set; }

    public string? Level7 { get; set; }

    public string? PersonInvEmployeeNumber { get; set; }

    public int? PersonInvHrid { get; set; }

    public string? PrimaryInjuryType { get; set; }

    public string? InjurySide { get; set; }

    public string? Body1 { get; set; }

    public string? Body2 { get; set; }

    public string? Body3 { get; set; }

    public string? Nature1 { get; set; }

    public string? Nature2 { get; set; }

    public string? Mechanism1 { get; set; }

    public string? Mechanism2 { get; set; }

    public string? Agency1 { get; set; }

    public string? Agency2 { get; set; }

    public string? DutyStatus { get; set; }

    public string? AccidentLocationCode { get; set; }

    public string? SpecificLocation { get; set; }

    public string? IncidentLocationAddress1 { get; set; }

    public string? IncidentLocationAddress2 { get; set; }

    public string? IncidentLocationAddress3 { get; set; }

    public string? IncidentLocationSuburb { get; set; }

    public string? IncidentLocationState { get; set; }

    public string? IncidentLocationPostcode { get; set; }

    public short? IncidentLocationInternational { get; set; }

    public string? IncidentLocationCountry { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual WhsBatchX Batch { get; set; } = null!;
}
