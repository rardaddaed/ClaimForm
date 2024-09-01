using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecPermission
{
    public int Permissionid { get; set; }

    public int? Objectid { get; set; }

    public string? Profile { get; set; }

    public short? Readaccess { get; set; }

    public short? Modifyaccess { get; set; }

    public short? Insertaccess { get; set; }

    public short? Deleteaccess { get; set; }

    public short? Propagateaccess { get; set; }

    public short? Executeaccess { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecObject? Object { get; set; }
}
