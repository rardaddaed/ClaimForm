using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmEventnotificationX
{
    public int Eventnotificationid { get; set; }

    public short? Active { get; set; }

    public string? Eventtitle { get; set; }

    public string? Triggeringevent { get; set; }

    public short? Sendnotification { get; set; }

    public int? Days { get; set; }

    public string? Subject { get; set; }

    public short? Includepdfreport { get; set; }

    public string? Body { get; set; }

    public short? Restrictedevents { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<AdmEventnotificationclientseverityX> AdmEventnotificationclientseverityXes { get; set; } = new List<AdmEventnotificationclientseverityX>();

    public virtual ICollection<AdmEventnotificationcomplaintX> AdmEventnotificationcomplaintXes { get; set; } = new List<AdmEventnotificationcomplaintX>();

    public virtual ICollection<AdmEventnotificationeventstatusX> AdmEventnotificationeventstatusXes { get; set; } = new List<AdmEventnotificationeventstatusX>();

    public virtual ICollection<AdmEventnotificationeventsubtypeX> AdmEventnotificationeventsubtypeXes { get; set; } = new List<AdmEventnotificationeventsubtypeX>();

    public virtual ICollection<AdmEventnotificationeventsubtypeclientX> AdmEventnotificationeventsubtypeclientXes { get; set; } = new List<AdmEventnotificationeventsubtypeclientX>();

    public virtual ICollection<AdmEventnotificationeventtypeX> AdmEventnotificationeventtypeXes { get; set; } = new List<AdmEventnotificationeventtypeX>();

    public virtual ICollection<AdmEventnotificationfeedbackX> AdmEventnotificationfeedbackXes { get; set; } = new List<AdmEventnotificationfeedbackX>();

    public virtual ICollection<AdmEventnotificationhazardX> AdmEventnotificationhazardXes { get; set; } = new List<AdmEventnotificationhazardX>();

    public virtual ICollection<AdmEventnotificationorgstructX> AdmEventnotificationorgstructXes { get; set; } = new List<AdmEventnotificationorgstructX>();

    public virtual ICollection<AdmEventnotificationrecipientX> AdmEventnotificationrecipientXes { get; set; } = new List<AdmEventnotificationrecipientX>();

    public virtual ICollection<AdmEventnotificationreportableX> AdmEventnotificationreportableXes { get; set; } = new List<AdmEventnotificationreportableX>();

    public virtual ICollection<AdmEventnotificationriskX> AdmEventnotificationriskXes { get; set; } = new List<AdmEventnotificationriskX>();

    public virtual ICollection<AdmEventnotificationroleX> AdmEventnotificationroleXes { get; set; } = new List<AdmEventnotificationroleX>();

    public virtual ICollection<AdmEventnotificationtreatmentX> AdmEventnotificationtreatmentXes { get; set; } = new List<AdmEventnotificationtreatmentX>();
}
