using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SecPosition
{
    public int Positionid { get; set; }

    public string? Positionname { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<AdmAuthorisationlevel> AdmAuthorisationlevels { get; set; } = new List<AdmAuthorisationlevel>();

    public virtual ICollection<AdmPorpositionX> AdmPorpositionXes { get; set; } = new List<AdmPorpositionX>();

    public virtual ICollection<PorUserpositionX> PorUserpositionXes { get; set; } = new List<PorUserpositionX>();

    public virtual ICollection<SecPositionprofile> SecPositionprofiles { get; set; } = new List<SecPositionprofile>();

    public virtual ICollection<SecUserposition> SecUserpositions { get; set; } = new List<SecUserposition>();

    public virtual ICollection<WfActionposition> WfActionpositions { get; set; } = new List<WfActionposition>();
}
