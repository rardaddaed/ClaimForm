using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class CorCorrespondenceout
{
    public int Correspondenceoutid { get; set; }

    public string? Documentcategory { get; set; }

    public string? Documenttype { get; set; }

    public int? Confidential { get; set; }

    public DateTime? Datesent { get; set; }

    public string? Sentto { get; set; }

    public string? Description { get; set; }

    public int? Enteredbyuserid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmCorrespondenceout> ClmCorrespondenceouts { get; set; } = new List<ClmCorrespondenceout>();

    public virtual ICollection<CorOutdocument> CorOutdocuments { get; set; } = new List<CorOutdocument>();

    public virtual SecUser? Enteredbyuser { get; set; }
}
