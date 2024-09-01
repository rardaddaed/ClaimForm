using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GlAccount
{
    public int Accountid { get; set; }

    public string? Referencenumber { get; set; }

    public short? Active { get; set; }

    public string? Category { get; set; }

    public string? Accounttype { get; set; }

    public string? Accountsubtype { get; set; }

    public string? Accountname { get; set; }

    public string? Description { get; set; }

    public string? Glcode { get; set; }

    public string? Costcentre { get; set; }

    public string? Taxcategory { get; set; }

    public string? Fmisreference { get; set; }

    public DateTime? Dateentered { get; set; }

    public DateTime? Datechanged { get; set; }

    public int? Enteredbyuserid { get; set; }

    public int? Updatedbyuserid { get; set; }

    public short? Debitmultiplier { get; set; }

    public short? Purchaseexpense { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Monetarymovement { get; set; }

    public virtual ICollection<ClmPurchaseitem> ClmPurchaseitems { get; set; } = new List<ClmPurchaseitem>();

    public virtual ICollection<ClmTreatment> ClmTreatments { get; set; } = new List<ClmTreatment>();

    public virtual SecUser? Enteredbyuser { get; set; }

    public virtual ICollection<GlEntry> GlEntries { get; set; } = new List<GlEntry>();

    public virtual ICollection<GlLinkedcode> GlLinkedcodes { get; set; } = new List<GlLinkedcode>();

    public virtual ICollection<GlPaymenttype> GlPaymenttypes { get; set; } = new List<GlPaymenttype>();

    public virtual ICollection<GlRule> GlRuleAccounts { get; set; } = new List<GlRule>();

    public virtual ICollection<GlRule> GlRuleCreditaccounts { get; set; } = new List<GlRule>();

    public virtual ICollection<GlRule> GlRuleCredittaxes { get; set; } = new List<GlRule>();

    public virtual ICollection<GlRule> GlRuleDebitaccounts { get; set; } = new List<GlRule>();

    public virtual ICollection<GlRule> GlRuleDebittaxes { get; set; } = new List<GlRule>();

    public virtual ICollection<GlSubentry> GlSubentries { get; set; } = new List<GlSubentry>();

    public virtual ICollection<PayItem> PayItems { get; set; } = new List<PayItem>();

    public virtual ICollection<PayTransaction> PayTransactions { get; set; } = new List<PayTransaction>();

    public virtual SecUser? Updatedbyuser { get; set; }
}
