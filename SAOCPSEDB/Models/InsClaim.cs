using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsClaim
{
    public int Insurerloadid { get; set; }

    public int Claimno { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public string? Previousclaimno { get; set; }

    public string? Workcoverclaimnumber { get; set; }

    public string? Claimstatuscodetype { get; set; }

    public string? Claimstatus { get; set; }

    public DateTime? Statusdate { get; set; }

    public DateTime? Injurydate { get; set; }

    public DateTime? Injurytime { get; set; }

    public DateTime? Datereceivedemployer { get; set; }

    public DateTime? Datereceivedinsurer { get; set; }

    public DateTime? Dateregistered { get; set; }

    public string? Claimclassificationcodetype { get; set; }

    public string? Claimclassification { get; set; }

    public string? Liabilitystatuscodetype { get; set; }

    public string? Liabilitystatus { get; set; }

    public DateTime? Liabilitystatusdate { get; set; }

    public string? Occupationcodetype { get; set; }

    public string? Occupation { get; set; }

    public string? Dutystatuscodetype { get; set; }

    public string? Dutystatus { get; set; }

    public string? Industrycodetype { get; set; }

    public string? Industry { get; set; }

    public string? Accidentlocationcodetype { get; set; }

    public string? Accidentlocation { get; set; }

    public string? Accidentaddress { get; set; }

    public string? Accidentsuburb { get; set; }

    public string? Accidentstate { get; set; }

    public string? Accidentpostcode { get; set; }

    public string? Descriptionofincident { get; set; }

    public string? Descriptionofinjuryillness { get; set; }

    public string? Employername { get; set; }

    public string? Resultcodecodetype { get; set; }

    public string? Resultcode { get; set; }

    public string? Injuryagencycodetype { get; set; }

    public string? Injuryagency { get; set; }

    public string? Injurymechanismcodetype { get; set; }

    public string? Injurymechanism { get; set; }

    public string? Injurynaturecodetype { get; set; }

    public string? Injurynature { get; set; }

    public string? Bodylocationcodetype { get; set; }

    public string? Bodylocation { get; set; }

    public string? Breakdowninjuryagencycodetype { get; set; }

    public string? Breakdowninjuryagency { get; set; }

    public DateTime? Dateofrecurrence { get; set; }

    public string? Employeesurname { get; set; }

    public string? Employeegivennames { get; set; }

    public string? Employeenumber { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public decimal? Averageweeklyearnings { get; set; }

    public int? Sharedclaim { get; set; }

    public string? Claimtypecodetype { get; set; }

    public string? Claimtype { get; set; }

    public int? Weekscount { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsInsurerload Insurerload { get; set; } = null!;
}
