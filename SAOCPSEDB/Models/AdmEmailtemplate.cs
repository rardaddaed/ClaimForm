using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmEmailtemplate
{
    public int Emailtemplateid { get; set; }

    public string? Emailtitle { get; set; }

    public short? Active { get; set; }

    public string? Notes { get; set; }

    public string? Subject { get; set; }

    public string? Securityclassification { get; set; }

    public string? Dlm { get; set; }

    public string? Emailbody { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public int? Includeemailsignature { get; set; }

    public virtual ICollection<AdmEmailtemplatedocument> AdmEmailtemplatedocuments { get; set; } = new List<AdmEmailtemplatedocument>();
}
