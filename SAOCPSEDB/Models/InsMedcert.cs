using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class InsMedcert
{
    public int Insurerloadid { get; set; }

    public int Insmedcertno { get; set; }

    public string? Loadstatus { get; set; }

    public string? Claimpolicynumber { get; set; }

    public int? State { get; set; }

    public string? Insurerclaimnumber { get; set; }

    public DateTime? Dateexamined { get; set; }

    public int? Nocapacity { get; set; }

    public DateTime? Nocapacityfromdate { get; set; }

    public DateTime? Nocapacitytodate { get; set; }

    public int? Capacitysuitableemployment { get; set; }

    public DateTime? Capacitysuitablefromdate { get; set; }

    public DateTime? Capacitysuitabletodate { get; set; }

    public int? Capacitypreinjuryemployment { get; set; }

    public DateTime? Capacitypreinjuryfromdate { get; set; }

    public string? Diagnosis { get; set; }

    public string? Treatmentplan { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual InsInsurerload Insurerload { get; set; } = null!;
}
