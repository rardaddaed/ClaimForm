using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class PorProviderX
{
    public int Providerid { get; set; }

    public string? Companyname { get; set; }

    public string? Providername { get; set; }

    public string? Abn { get; set; }

    public string? Providertype { get; set; }

    public string? Sadpcvendornumber { get; set; }

    public int? Streetsameaspostal { get; set; }

    public string? Streetaddressline1 { get; set; }

    public string? Streetaddressline2 { get; set; }

    public string? Streetaddressline3 { get; set; }

    public string? Streetsuburb { get; set; }

    public string? Streetstate { get; set; }

    public string? Streetpostcode { get; set; }

    public int? Streetinternational { get; set; }

    public string? Streetcountry { get; set; }

    public string? Postaladdressline1 { get; set; }

    public string? Postaladdressline2 { get; set; }

    public string? Postaladdressline3 { get; set; }

    public string? Postalsuburb { get; set; }

    public string? Postalstate { get; set; }

    public string? Postalpostcode { get; set; }

    public int? Postalinternational { get; set; }

    public string? Postalcountry { get; set; }

    public string? Contactname { get; set; }

    public string? Phone { get; set; }

    public string? Workphone { get; set; }

    public string? Mobilephone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public int? Eftpayments { get; set; }

    public string? Bankname { get; set; }

    public string? Bankbranch { get; set; }

    public string? Accountname { get; set; }

    public string? Bsb1 { get; set; }

    public string? Bsb2 { get; set; }

    public string? Accountnumber { get; set; }

    public string? Reasonforchange { get; set; }

    public string? Comments { get; set; }

    public int? Manageruserid { get; set; }

    public string? Manageremail { get; set; }

    public int? Requestedbyuserid { get; set; }

    public DateTime? Daterequested { get; set; }

    public int? Reviewedbyuserid { get; set; }

    public DateTime? Datemanagerreviewed { get; set; }

    public int? Managerapprovalaction { get; set; }

    public string? Managercomments { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public int? Simsproviderid { get; set; }

    public int? Providerformtype { get; set; }

    public string? Requeststatus { get; set; }

    public DateTime? Requeststatusdatetime { get; set; }

    public int? Simslocationno { get; set; }

    public int? Simsbankno { get; set; }

    public int? Simscontactno { get; set; }

    public DateTime? Providertypeeffectivefromdate { get; set; }

    public string? Medicalprovidernumber { get; set; }

    public virtual SecUser? Manageruser { get; set; }

    public virtual ICollection<PorProvideractionhistoryX> PorProvideractionhistoryXes { get; set; } = new List<PorProvideractionhistoryX>();

    public virtual ICollection<PorProviderassociateddocumentX> PorProviderassociateddocumentXes { get; set; } = new List<PorProviderassociateddocumentX>();

    public virtual SecUser? Requestedbyuser { get; set; }

    public virtual SecUser? Reviewedbyuser { get; set; }
}
