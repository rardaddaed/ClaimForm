using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class SiteSite
{
    public int Siteid { get; set; }

    public string? Sitenumber { get; set; }

    public string? Sitename { get; set; }

    public short? Active { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? International { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Contactname { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }

    public virtual ICollection<SiteLicenceSa> SiteLicenceSas { get; set; } = new List<SiteLicenceSa>();

    public virtual SiteSiteSa? SiteSiteSa { get; set; }
}
