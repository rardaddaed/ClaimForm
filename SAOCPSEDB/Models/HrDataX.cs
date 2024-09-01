using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HrDataX
{
    public int Hrid { get; set; }

    public string? Personid { get; set; }

    public string? Middlename { get; set; }

    public string? Preferredname { get; set; }

    public string? Employmenttype { get; set; }

    public string? Employmentclassification { get; set; }

    public string? Jobtitle { get; set; }

    public string? Anzsco { get; set; }

    public string? Countryofbirth { get; set; }

    public string? Language { get; set; }

    public string? Emailaddresspersonal { get; set; }

    public string? Employmentstatus { get; set; }

    public string? Orgheirarchyid { get; set; }

    public DateTime? Agencystartdate { get; set; }

    public DateTime? Validfrom { get; set; }

    public DateTime? Validto { get; set; }

    public int? Active { get; set; }

    public DateTime? AuditCreated { get; set; }

    public DateTime? AuditLastmodified { get; set; }

    public int? AuditRowversion { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Orgagencycode { get; set; }

    public string? Managingsupervisornumber { get; set; }

    public DateTime? Datecreated { get; set; }

    public string? Simsworkerno { get; set; }

    public virtual HrDatum Hr { get; set; } = null!;
}
