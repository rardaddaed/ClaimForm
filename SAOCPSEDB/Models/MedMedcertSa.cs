using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MedMedcertSa
{
    public int Medcertid { get; set; }

    public string? Certificatenumber { get; set; }

    public short? Issuedby { get; set; }

    public string? Statedcauseofinjury { get; set; }

    public DateTime? Stateddateofinjury { get; set; }

    public short? Conditionoccurrence { get; set; }

    public string? Certificationreason { get; set; }

    public int? Estimatedrtwdays { get; set; }

    public int? Estimatedrtwweeks { get; set; }

    public short? Estimatedrtwuncertain { get; set; }

    public short? Reviewatnextconsult { get; set; }

    public string? Certificationcomments { get; set; }

    public string? Treatmentplan { get; set; }

    public short? Medicalspecialist { get; set; }

    public string? Medicalspecialistname { get; set; }

    public short? Psychologist { get; set; }

    public string? Psychologistname { get; set; }

    public short? Physiotherapist { get; set; }

    public string? Physiotherapistname { get; set; }

    public short? Otherspecialist { get; set; }

    public string? Otherspecialistname { get; set; }

    public short? Norestrictions { get; set; }

    public string? Sitting { get; set; }

    public string? Reachingaboveshoulder { get; set; }

    public string? Neckmovement { get; set; }

    public string? Standingwalking { get; set; }

    public string? Bending { get; set; }

    public string? Stepsstairsladders { get; set; }

    public string? Kneelingsquating { get; set; }

    public string? Useunaffectedbodypart { get; set; }

    public string? Driving { get; set; }

    public string? Carryingholdinglifting { get; set; }

    public string? Attentionconcentration { get; set; }

    public string? Memory { get; set; }

    public string? Judgement { get; set; }

    public string? Additionalcomments { get; set; }

    public string? Otherfunctionalconsideration { get; set; }

    public string? Medicationsprescribed { get; set; }

    public short? Graduatedincrease { get; set; }

    public short? Graduatedweeks { get; set; }

    public decimal? Graduatedhoursadayfrom { get; set; }

    public decimal? Graduatedhoursadayto { get; set; }

    public short? Nonconsecutivedays { get; set; }

    public int? Nonconsecutiveperioddays { get; set; }

    public int? Nonconsecutiveperiodweeks { get; set; }

    public short? Requestedrtwoptions { get; set; }

    public short? Requestedrtwplancopy { get; set; }

    public short? Casemanagercontactrequired { get; set; }

    public string? Preferredcontactmethod { get; set; }

    public short? Employercontactrequired { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual MedMedcert Medcert { get; set; } = null!;
}
