using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmEventnotificationfeedbackX
{
    public int Eventnotificationid { get; set; }

    public int Feedbackno { get; set; }

    public string? Feedbacktype { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual AdmEventnotificationX Eventnotification { get; set; } = null!;
}
