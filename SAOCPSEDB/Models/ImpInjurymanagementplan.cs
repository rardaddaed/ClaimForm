using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ImpInjurymanagementplan
{
    public int Injurymanagementplanid { get; set; }

    public int? Plannumber { get; set; }

    public DateTime? Dateprepared { get; set; }

    public string? Rtwcoordinator { get; set; }

    public string? Rtwcoordinatorphone { get; set; }

    public int? Rehabmanagerid { get; set; }

    public int? Nominatedtreatingdoctorid { get; set; }

    public int? Rehabilitationproviderid { get; set; }

    public string? Injurymanagementgoal { get; set; }

    public DateTime? Dateachieveestimated { get; set; }

    public DateTime? Datereview { get; set; }

    public string? Progresssummary { get; set; }

    public short? Consulteddoctor { get; set; }

    public short? Consultedinjuredworker { get; set; }

    public short? Consultedemployer { get; set; }

    public short? Consultedrtwcoordinator { get; set; }

    public short? Consultedrehabmanager { get; set; }

    public short? Consultedrehabprovider { get; set; }

    public int? Plandocumentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmInjurymanagementplan> ClmInjurymanagementplans { get; set; } = new List<ClmInjurymanagementplan>();

    public virtual ICollection<ImpDocument> ImpDocuments { get; set; } = new List<ImpDocument>();

    public virtual ParParty? Nominatedtreatingdoctor { get; set; }

    public virtual ParParty? Rehabilitationprovider { get; set; }

    public virtual SecUser? Rehabmanager { get; set; }
}
