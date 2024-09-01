using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmPiawe
{
    public int Claimid { get; set; }

    public int Piaweno { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredbyid { get; set; }

    public short? Finalised { get; set; }

    public DateTime? Datefinalised { get; set; }

    public int? Finalisedbyid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Authorised { get; set; }

    public DateTime? Dateauthorised { get; set; }

    public byte? Overrideweeksassessed { get; set; }

    public int? Authorisedbyid { get; set; }

    public virtual SecUser? Authorisedby { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ClmPiaweSa? ClmPiaweSa { get; set; }

    public virtual ICollection<ClmPiawedocument> ClmPiawedocuments { get; set; } = new List<ClmPiawedocument>();

    public virtual ICollection<ClmPiawehistory> ClmPiawehistories { get; set; } = new List<ClmPiawehistory>();

    public virtual ICollection<ClmPiawemodifyhistory> ClmPiawemodifyhistories { get; set; } = new List<ClmPiawemodifyhistory>();

    public virtual SecUser? Enteredby { get; set; }

    public virtual SecUser? Finalisedby { get; set; }
}
