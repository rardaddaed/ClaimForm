using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class IncExposureX
{
    public int Incidentid { get; set; }

    public string? Activity { get; set; }

    public string? Activityother { get; set; }

    public string? Substance { get; set; }

    public string? Substanceother { get; set; }

    public string? Extent { get; set; }

    public string? Extentunknown { get; set; }

    public int? Ppeworn { get; set; }

    public string? Sharptype { get; set; }

    public string? Sharpother { get; set; }

    public int? Sharpcontaminated { get; set; }

    public string? Exposuremethod { get; set; }

    public string? Exposureother { get; set; }

    public string? Exposurecauseother { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Firstaidapplied { get; set; }

    public short? Rinsing { get; set; }

    public short? Washing { get; set; }

    public short? Antiseptics { get; set; }

    public string? Othertreatment { get; set; }

    public short? Completedvaccine { get; set; }

    public string? Vaccinemonth { get; set; }

    public int? Vaccineyear { get; set; }

    public short? Infected { get; set; }

    public string? Comments { get; set; }

    public virtual ICollection<IncExposureareaX> IncExposureareaXes { get; set; } = new List<IncExposureareaX>();

    public virtual ICollection<IncExposurecauseX> IncExposurecausexes { get; set; } = new List<IncExposurecauseX>();

    public virtual ICollection<IncExposureppeX> IncExposureppeXes { get; set; } = new List<IncExposureppeX>();

    public virtual IncIncidentX1 Incident { get; set; } = null!;
}
