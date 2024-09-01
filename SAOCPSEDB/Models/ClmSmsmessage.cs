using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmSmsmessage
{
    public int Claimid { get; set; }

    public int Smsrecipientno { get; set; }

    public int Smsmessageno { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdatetime { get; set; }

    public DateTime? Datesent { get; set; }

    public DateTime? Timesent { get; set; }

    public int? Senderuserid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ClmSmsrecipient ClmSmsrecipient { get; set; } = null!;

    public virtual SecUser? Senderuser { get; set; }
}
