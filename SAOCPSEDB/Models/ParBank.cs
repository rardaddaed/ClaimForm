using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParBank
{
    public int Partyid { get; set; }

    public int Locationno { get; set; }

    public int Bankno { get; set; }

    public int? Active { get; set; }

    public string? Paymentmethod { get; set; }

    public string? Bankname { get; set; }

    public string? Bankbranch { get; set; }

    public string? Accountname { get; set; }

    public string? Bsb1 { get; set; }

    public string? Bsb2 { get; set; }

    public string? Accountnumber { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Remittancemethod { get; set; }

    public string? Intbankname { get; set; }

    public string? Intaccountname { get; set; }

    public string? Intaddress { get; set; }

    public string? Inttowncity { get; set; }

    public string? Country { get; set; }

    public string? Currency { get; set; }

    public string? Swiftbic { get; set; }

    public string? Beneficiarycode { get; set; }

    public string? Specialrequirements { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredby { get; set; }

    public DateTime? Datemodifed { get; set; }

    public int? Modifiedby { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual SecUser? EnteredbyNavigation { get; set; }

    public virtual SecUser? ModifiedbyNavigation { get; set; }

    public virtual ParLocation ParLocation { get; set; } = null!;

    public virtual ParParty Party { get; set; } = null!;

    public virtual ICollection<PayPayee> PayPayees { get; set; } = new List<PayPayee>();
}
