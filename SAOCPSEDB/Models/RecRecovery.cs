using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class RecRecovery
{
    public int Recoveryid { get; set; }

    public DateTime? Dateentered { get; set; }

    public int? Enteredbyuserid { get; set; }

    public int? Jurisdictionzone { get; set; }

    public DateTime? Daterecoveryreceived { get; set; }

    public decimal? Recoveryamount { get; set; }

    public string? Recoverycategory { get; set; }

    public string? Recoveryestimatecategory { get; set; }

    public int? Partyid { get; set; }

    public int? Locationno { get; set; }

    public string? Partyname { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public short? International { get; set; }

    public string? Country { get; set; }

    public string? Paymentmethod { get; set; }

    public string? Chequeeftnumber { get; set; }

    public string? Details { get; set; }

    public int? Documentid { get; set; }

    public short? Finalised { get; set; }

    public DateTime? Datefinalised { get; set; }

    public int? Finalisedbyuserid { get; set; }

    public decimal? Finalisedamount { get; set; }

    public int? Transactionid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<ClmRecovery> ClmRecoveries { get; set; } = new List<ClmRecovery>();

    public virtual DmsDocument? Document { get; set; }

    public virtual SecUser? Enteredbyuser { get; set; }

    public virtual SecUser? Finalisedbyuser { get; set; }

    public virtual ParLocation? ParLocation { get; set; }

    public virtual RecRecoveryWa? RecRecoveryWa { get; set; }

    public virtual RecRecoveryX? RecRecoveryX { get; set; }

    public virtual GlTransaction? Transaction { get; set; }
}
