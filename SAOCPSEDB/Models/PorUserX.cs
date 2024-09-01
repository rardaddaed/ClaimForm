using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PorUserX
{
    public int Userid { get; set; }

    public short? Active { get; set; }

    public string? Logonid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public int? Supervisoruserid { get; set; }

    public int? Documentid { get; set; }

    public int? Orgstructid { get; set; }

    public string? Reasonforchange { get; set; }

    public string? Additionaldetails { get; set; }

    public int? Requestedbyuserid { get; set; }

    public DateTime? Daterequested { get; set; }

    public int? Reviewedbyuserid { get; set; }

    public DateTime? Datemanagerreviewed { get; set; }

    public int? Managerapprovalaction { get; set; }

    public string? Managercomments { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Simsuserid { get; set; }

    public int? Userformtype { get; set; }

    public int? Manageruserid { get; set; }

    public string? Manageremail { get; set; }

    public string? Requeststatus { get; set; }

    public DateTime? Requeststatusdatetime { get; set; }

    public virtual DmsDocument? Document { get; set; }

    public virtual SecUser? Manageruser { get; set; }

    public virtual OsOrgstructure? Orgstruct { get; set; }

    public virtual ICollection<PorUserassociateddocumentX> PorUserassociateddocumentXes { get; set; } = new List<PorUserassociateddocumentX>();

    public virtual ICollection<PorUserpositionX> PorUserpositionXes { get; set; } = new List<PorUserpositionX>();

    public virtual SecUser? Requestedbyuser { get; set; }

    public virtual SecUser? Reviewedbyuser { get; set; }

    public virtual SecUser? Supervisoruser { get; set; }
}
