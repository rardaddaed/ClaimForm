using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtInvestigationmechanismX
{
    public int Eventid { get; set; }

    public string? Mechanismofevent { get; set; }

    public string? Mfalheight { get; set; }

    public string? Mfalsamelevel { get; set; }

    public string? Mfaldescription { get; set; }

    public string? Mobjstationary { get; set; }

    public string? Mobjmoving { get; set; }

    public string? Mobjrubbing { get; set; }

    public string? Mmechvibration { get; set; }

    public string? Mhitmovingobject { get; set; }

    public string? Mhitfalling { get; set; }

    public string? Mhitbittenanimal { get; set; }

    public string? Mhitpersonaccident { get; set; }

    public string? Mhitassault { get; set; }

    public short? Mhitmachinery { get; set; }

    public short? Mhittrappedstationary { get; set; }

    public string? Msndsingle { get; set; }

    public string? Msndlongterm { get; set; }

    public string? Msndchgpressureexp { get; set; }

    public string? Msndothrvarpressure { get; set; }

    public string? Msndnoisereadingdb { get; set; }

    public string? Mbdylifting { get; set; }

    public string? Mbdyotherthanlifting { get; set; }

    public string? Mbdynoobjects { get; set; }

    public string? Mbdyrepetitive { get; set; }

    public string? Menvhotobject { get; set; }

    public string? Menvcoldobject { get; set; }

    public string? Menvenvheat { get; set; }

    public string? Menvenvcold { get; set; }

    public string? Menvnonionradiation { get; set; }

    public string? Menvionradiation { get; set; }

    public string? Menvelectricity { get; set; }

    public short? Menvreportedtotheotr { get; set; }

    public short? Menvimmersiondrowning { get; set; }

    public string? Menvimmersionwatertype { get; set; }

    public short? Menvexposureotherenvfactors { get; set; }

    public string? Menvexposurefactorsinvolved { get; set; }

    public string? Mchmsinglecontact { get; set; }

    public string? Mchmlongtermcontact { get; set; }

    public string? Mchmothercontact { get; set; }

    public short? Mchminsectbites { get; set; }

    public string? Mchminsectbitesdetail { get; set; }

    public short? Mchmpoisonousplant { get; set; }

    public string? Mchmpoisonousplantdetail { get; set; }

    public string? Mbiononhuman { get; set; }

    public string? Mbiohuman { get; set; }

    public string? Mmentraumaticevent { get; set; }

    public string? Mmenworkplaceviolence { get; set; }

    public string? Mmenworkpressure { get; set; }

    public short? Mmenexposedtosuicideincident { get; set; }

    public string? Mmenworkharassment { get; set; }

    public string? Mmensexualharassment { get; set; }

    public short? Mmeninrelationtosuicide { get; set; }

    public short? Mmenreferredtoeap { get; set; }

    public short? Mmeneapaccessed { get; set; }

    public string? Mvehlandcollapse { get; set; }

    public string? Mvehrolloverequipment { get; set; }

    public string? Mvehinvolvemotorvehicle { get; set; }

    public string? Mvehmultiplemechanism { get; set; }

    public string? Mvehunabletoidentify { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
