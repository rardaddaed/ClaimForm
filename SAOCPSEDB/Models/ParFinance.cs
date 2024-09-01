using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ParFinance
{
    public int Partyid { get; set; }

    public string? Financialstatus { get; set; }

    public DateTime? Dateauthorised { get; set; }

    public int? Authoriseduserid { get; set; }

    public short? Approvedvendor { get; set; }

    public string? Taxfilenumber { get; set; }

    public short? Australianresident { get; set; }

    public short? Taxfreethreshold { get; set; }

    public short? Fullmedicareexemption { get; set; }

    public short? Paygpayee { get; set; }

    public string? Paygtaxscale { get; set; }

    public short? Paygvariation { get; set; }

    public decimal? Paygweeklyamount { get; set; }

    public decimal? Paygweeklypercent { get; set; }

    public DateTime? Paygeffectivedate { get; set; }

    public short? Smallbusiness { get; set; }

    public int? Paymentterms { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Noabnwithholdingexemption { get; set; }

    public short? Comprecipientpaygapplies { get; set; }

    public virtual SecUser? Authoriseduser { get; set; }

    public virtual ICollection<ParFinstatushistory> ParFinstatushistories { get; set; } = new List<ParFinstatushistory>();

    public virtual ParParty Party { get; set; } = null!;
}
