using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GlTransaction
{
    public int Transactionid { get; set; }

    public string? Transactiontype { get; set; }

    public DateTime? Transactiondatetime { get; set; }

    public int? Partyid { get; set; }

    public int? Partylocationno { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmEstimate> ClmEstimates { get; set; } = new List<ClmEstimate>();

    public virtual ICollection<ClmPurchaseauth> ClmPurchaseauths { get; set; } = new List<ClmPurchaseauth>();

    public virtual ICollection<ClmPurchaseitem> ClmPurchaseitems { get; set; } = new List<ClmPurchaseitem>();

    public virtual ICollection<ClmRecoveryestimate> ClmRecoveryestimates { get; set; } = new List<ClmRecoveryestimate>();

    public virtual ICollection<GlEntry> GlEntries { get; set; } = new List<GlEntry>();

    public virtual ICollection<GlSubentry> GlSubentries { get; set; } = new List<GlSubentry>();

    public virtual ParLocation? ParLocation { get; set; }

    public virtual ParParty? Party { get; set; }

    public virtual ICollection<PayItemtransaction> PayItemtransactions { get; set; } = new List<PayItemtransaction>();

    public virtual ICollection<PayPayee> PayPayees { get; set; } = new List<PayPayee>();

    public virtual ICollection<PayTransaction> PayTransactions { get; set; } = new List<PayTransaction>();

    public virtual ICollection<RecRecovery> RecRecoveries { get; set; } = new List<RecRecovery>();
}
