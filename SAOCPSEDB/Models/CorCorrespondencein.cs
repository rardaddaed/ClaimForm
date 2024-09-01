using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class CorCorrespondencein
{
    public int Correspondenceinid { get; set; }

    public string? Documentcategory { get; set; }

    public string? Documenttype { get; set; }

    public int? Confidential { get; set; }

    public DateTime? Datereceived { get; set; }

    public DateTime? Documentdate { get; set; }

    public string? Receiptmethodcodetype { get; set; }

    public string? Receiptmethod { get; set; }

    public string? Receivedfrom { get; set; }

    public string? Description { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Enteredbyuserid { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Timeentered { get; set; }

    public virtual ICollection<ClmCorrespondencein> ClmCorrespondenceins { get; set; } = new List<ClmCorrespondencein>();

    public virtual ICollection<CorIndocument> CorIndocuments { get; set; } = new List<CorIndocument>();

    public virtual SecUser? Enteredbyuser { get; set; }

    public virtual ICollection<ParBusinessdocument> ParBusinessdocuments { get; set; } = new List<ParBusinessdocument>();

    public virtual ICollection<ParCorrespondencein> ParCorrespondenceins { get; set; } = new List<ParCorrespondencein>();
}
