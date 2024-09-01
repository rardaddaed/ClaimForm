using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class LegLegalentity
{
    public int Legalentityid { get; set; }

    public int? Active { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Employerlegalname { get; set; }

    public string? Employerothername { get; set; }

    public string? Employertradingname { get; set; }

    public string? Employerabn { get; set; }

    public string? Employeracn { get; set; }

    public string? Phone { get; set; }

    public string? Mobilephone { get; set; }

    public string? Email { get; set; }

    public string? Streetaddressline1 { get; set; }

    public string? Streetaddressline2 { get; set; }

    public string? Streetaddressline3 { get; set; }

    public string? Streetsuburb { get; set; }

    public string? Streetstate { get; set; }

    public string? Streetpostcode { get; set; }

    public int? Postalsameasstreet { get; set; }

    public string? Postaladdressline1 { get; set; }

    public string? Postaladdressline2 { get; set; }

    public string? Postaladdressline3 { get; set; }

    public string? Postalsuburb { get; set; }

    public string? Postalstate { get; set; }

    public string? Postalpostcode { get; set; }

    public string? Notes { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmLegalentity> ClmLegalentities { get; set; } = new List<ClmLegalentity>();

    public virtual LegLegalentityX? LegLegalentityX { get; set; }

    public virtual ICollection<LegOrgstructure> LegOrgstructures { get; set; } = new List<LegOrgstructure>();

    public virtual ICollection<LegPolicy> LegPolicies { get; set; } = new List<LegPolicy>();
}
