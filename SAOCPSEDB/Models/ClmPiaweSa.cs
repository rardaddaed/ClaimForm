using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPiaweSa
{
    public int Claimid { get; set; }

    public int Piaweno { get; set; }

    public DateTime? Dateassessedfrom { get; set; }

    public DateTime? Dateassessedto { get; set; }

    public decimal? Baseweeksassessed { get; set; }

    public decimal? Overtimeweeksassessed { get; set; }

    public decimal? Penaltiesweeksassessed { get; set; }

    public short? Includeovertime { get; set; }

    public short? Includepenalties { get; set; }

    public decimal? Baserateofpaytotalhours { get; set; }

    public decimal? Baserateofpaytotalpaid { get; set; }

    public decimal? Baserateofpayaveragehours { get; set; }

    public decimal? Baserateofpayaveragepaid { get; set; }

    public decimal? Overtimetotalhours { get; set; }

    public decimal? Overtimetotalpaid { get; set; }

    public decimal? Overtimeaveragehours { get; set; }

    public decimal? Overtimeaveragepaid { get; set; }

    public decimal? Penaltiestotalhours { get; set; }

    public decimal? Penaltiestotalpaid { get; set; }

    public decimal? Penaltiesaveragehours { get; set; }

    public decimal? Penaltiesaveragepaid { get; set; }

    public decimal? Nonpectotalhours { get; set; }

    public decimal? Nonpectotalpaid { get; set; }

    public decimal? Nonpecaveragehours { get; set; }

    public decimal? Nonpecaveragepaid { get; set; }

    public decimal? Calculatedpiawehours { get; set; }

    public decimal? Calculatedpiawepaid { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public decimal? Totalhours { get; set; }

    public decimal? Totalpaid { get; set; }

    public short? Requestdatefrom { get; set; }

    public virtual ClmPiawe ClmPiawe { get; set; } = null!;
}
