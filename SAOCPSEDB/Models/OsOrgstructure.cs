using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public class OsOrgstructure
{
    public int Orgstructid { get; set; }

    public DateTime? Dateentered { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<AdmOrgemailX> AdmOrgemailXes { get; set; } = new List<AdmOrgemailX>();

    public virtual ICollection<ClmempEmployment> ClmempEmployments { get; set; } = new List<ClmempEmployment>();

    public virtual ICollection<ClmfrmClaimX> ClmfrmClaimXes { get; set; } = new List<ClmfrmClaimX>();

    public virtual ICollection<EvtEventX1> EvtEventX1s { get; set; } = new List<EvtEventX1>();

    public virtual ICollection<HrDatum> HrData { get; set; } = new List<HrDatum>();

    public virtual ICollection<IncIncidentX1> IncIncidentX1s { get; set; } = new List<IncIncidentX1>();

    public virtual ICollection<IncnotiOrganisationalstructureX> IncnotiOrganisationalstructureXes { get; set; } = new List<IncnotiOrganisationalstructureX>();

    public virtual ICollection<LegOrgstructure> LegOrgstructures { get; set; } = new List<LegOrgstructure>();

    public virtual ICollection<MtpFundorgstructX> MtpFundorgstructXes { get; set; } = new List<MtpFundorgstructX>();

    public virtual ICollection<MtpOrgstructX> MtpOrgstructXes { get; set; } = new List<MtpOrgstructX>();

    public virtual OsOrgstructureX? OsOrgstructureX { get; set; }

    public virtual ICollection<PayPayment> PayPayments { get; set; } = new List<PayPayment>();

    public virtual ICollection<PorUserX> PorUserXes { get; set; } = new List<PorUserX>();

    public virtual ICollection<TeamOrgstructX> TeamOrgstructXes { get; set; } = new List<TeamOrgstructX>();

    public virtual ICollection<WfEventOrgstructX> WfEventOrgstructXes { get; set; } = new List<WfEventOrgstructX>();
}
