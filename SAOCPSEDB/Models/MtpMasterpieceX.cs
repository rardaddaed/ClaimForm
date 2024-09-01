using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class MtpMasterpieceX
{
    public int Masterpieceid { get; set; }

    public string? Profilename { get; set; }

    public string? Filename { get; set; }

    public short? Mastervendorfile { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<MtpBatchnumberX> MtpBatchnumberXes { get; set; } = new List<MtpBatchnumberX>();

    public virtual ICollection<MtpOrgstructX> MtpOrgstructXes { get; set; } = new List<MtpOrgstructX>();

    public virtual ICollection<MtpVariableX> MtpVariableXes { get; set; } = new List<MtpVariableX>();

    public virtual ICollection<PayPayeeX> PayPayeeXes { get; set; } = new List<PayPayeeX>();
}
