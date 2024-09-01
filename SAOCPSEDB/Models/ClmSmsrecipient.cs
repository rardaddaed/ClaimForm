using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmSmsrecipient
{
    public int Claimid { get; set; }

    public int Smsrecipientno { get; set; }

    public string? Recipient { get; set; }

    public string? Mobile { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Enteredby { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Timeentered { get; set; }

    public virtual ClmClaim1 Claim { get; set; } = null!;

    public virtual ICollection<ClmSmsmessage> ClmSmsmessages { get; set; } = new List<ClmSmsmessage>();

    public virtual SecUser? EnteredbyNavigation { get; set; }
}
