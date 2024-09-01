using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HrPasswordX
{
    public int Hrid { get; set; }

    public DateTime? AuditCreated { get; set; }

    public DateTime? AuditLastmodified { get; set; }

    public int? AuditRowversion { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public byte[]? Password { get; set; }

    public string? Salt { get; set; }

    public byte[]? Hashedpassword { get; set; }

    public virtual HrDatum Hr { get; set; } = null!;

    public virtual ICollection<HrPasswordhistoryX> HrPasswordhistoryXes { get; set; } = new List<HrPasswordhistoryX>();
}
