using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RehRehabX
{
    public int Rehabid { get; set; }

    public short? Internalexternal { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Rtwplannumber { get; set; }

    public DateTime? Consultationdate { get; set; }

    public DateTime? Dateplanreceived { get; set; }

    public string? Rtwconsultant { get; set; }

    public string? Rtwconsultantphone { get; set; }

    public string? Supervisor { get; set; }

    public string? Supervisorphone { get; set; }

    public int? Nominatedtreatingdoctorid { get; set; }

    public int? Rtwproviderid { get; set; }

    public DateTime? Datefrom { get; set; }

    public DateTime? Dateto { get; set; }

    public DateTime? Reviewdate { get; set; }

    public DateTime? Dateprepared { get; set; }

    public string? Preparedby { get; set; }

    public string? Objective { get; set; }

    public string? Additionalgoals { get; set; }

    public short? Signedbydoctor { get; set; }

    public short? Signedbyemployee { get; set; }

    public short? Signedbysupervisor { get; set; }

    public short? Signedbyrtwconsultant { get; set; }

    public short? Signedbycasemanager { get; set; }

    public short? Signedbyrtwprovider { get; set; }

    public short? Nosuitabledutiesavailable { get; set; }

    public short? Workconductedat { get; set; }

    public short? Positiontype { get; set; }

    public string? Positionsupervisor { get; set; }

    public string? Positiondetails { get; set; }

    public string? Worksitedetails { get; set; }

    public string? Outcome { get; set; }

    public DateTime? Outcomedate { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual ParParty? Nominatedtreatingdoctor { get; set; }

    public virtual RehRehab Rehab { get; set; } = null!;

    public virtual ParParty? Rtwprovider { get; set; }
}
