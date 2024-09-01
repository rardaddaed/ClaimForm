using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class HrBatchStagingX
{
    public int Batchid { get; set; }

    public int Rownumber { get; set; }

    public int? Invalid { get; set; }

    public int? Hrid { get; set; }

    public string? Employeenumber { get; set; }

    public string? Personid { get; set; }

    public string? Familyname { get; set; }

    public string? Givenname { get; set; }

    public string? Middlename { get; set; }

    public string? Preferredname { get; set; }

    public DateTime? Dateofbirth { get; set; }

    public string? Gender { get; set; }

    public string? Atsi { get; set; }

    public string? Emailaddress { get; set; }

    public DateTime? Employeestartdate { get; set; }

    public string? Employmenttype { get; set; }

    public string? Employmentclassification { get; set; }

    public string? Jobtitle { get; set; }

    public DateTime? Terminationresignationdate { get; set; }

    public string? Anzsco { get; set; }

    public string? Title { get; set; }

    public string? Countryofbirth { get; set; }

    public string? Language { get; set; }

    public string? Addressline1 { get; set; }

    public string? Addressline2 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public string? Homephone { get; set; }

    public string? Mobilephone { get; set; }

    public string? Emailaddresspersonal { get; set; }

    public string? Employmentstatus { get; set; }

    public string? Workphone { get; set; }

    public string? Orgheirarchyid { get; set; }

    public DateTime? Agencystartdate { get; set; }

    public DateTime? Validfrom { get; set; }

    public DateTime? Validto { get; set; }

    public string? Active { get; set; }

    public DateTime? AuditCreated { get; set; }

    public DateTime? AuditLastmodified { get; set; }

    public int? AuditRowversion { get; set; }

    public byte[]? Timestamp { get; set; }

    public string? Orgagencycode { get; set; }

    public string? Managingsupervisor { get; set; }

    public virtual HrBatchX Batch { get; set; } = null!;
}
