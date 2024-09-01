using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PorInjuredworkerX
{
    public int Injuredworkerid { get; set; }

    public string? Familyname { get; set; }

    public string? Givenname { get; set; }

    public string? Employeenumber { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Bankname { get; set; }

    public string? Bankbranch { get; set; }

    public string? Accountname { get; set; }

    public string? Bsb1 { get; set; }

    public string? Bsb2 { get; set; }

    public string? Accountnumber { get; set; }

    public string? Reasonforchange { get; set; }

    public int? Manageruserid { get; set; }

    public string? Manageremail { get; set; }

    public int? Requestedbyuserid { get; set; }

    public DateTime? Daterequested { get; set; }

    public int? Reviewedbyuserid { get; set; }

    public DateTime? Datemanagerreviewed { get; set; }

    public int? Managerapprovalaction { get; set; }

    public string? Managercomments { get; set; }

    public string? Requeststatus { get; set; }

    public DateTime? Requeststatusdatetime { get; set; }

    public int? Simspartyid { get; set; }

    public int? Simslocationno { get; set; }

    public int? Simsbankno { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? Manageruser { get; set; }

    public virtual ICollection<PorInjuredworkerassociateddocumentX> PorInjuredworkerassociateddocumentXes { get; set; } = new List<PorInjuredworkerassociateddocumentX>();

    public virtual SecUser? Requestedbyuser { get; set; }

    public virtual SecUser? Reviewedbyuser { get; set; }
}
