using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncManualtaskX
{
    public int Incidentid { get; set; }

    public int? Highforce { get; set; }

    public int? Prolongedforce { get; set; }

    public int? Repetitivemovement { get; set; }

    public int? Sustainedposture { get; set; }

    public int? Exposuretovibration { get; set; }

    public int? Involvedperson { get; set; }

    public string? Persontype { get; set; }

    public int? Involvedpartyid { get; set; }

    public string? Employeenumber { get; set; }

    public string? Firstname { get; set; }

    public string? Surname { get; set; }

    public int? Gender { get; set; }

    public int? Personcooperated { get; set; }

    public int? Numberofpeople { get; set; }

    public int? Assistancesought { get; set; }

    public int? Sufficientavailable { get; set; }

    public int? Sufficientroom { get; set; }

    public int? Surfaceadjustable { get; set; }

    public int? Surfacewasadjusted { get; set; }

    public int? Unexpectedmovement { get; set; }

    public int? Equipmentrequired { get; set; }

    public int? Equipmentavailable { get; set; }

    public int? Equipmentused { get; set; }

    public int? Equipmentworking { get; set; }

    public string? Equipmenttype { get; set; }

    public string? Equipmentother { get; set; }

    public int? Manualhandlingtraining { get; set; }

    public int? Manualtrainingyear { get; set; }

    public string? Manualtrainingother { get; set; }

    public string? Manualtrainingnone { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
