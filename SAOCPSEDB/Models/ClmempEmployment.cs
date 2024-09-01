using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class ClmempEmployment
{
    public int Claimemploymentid { get; set; }

    public string? Claimemploymenttype { get; set; }

    public int? Orgstructid { get; set; }

    public string? Addressline1 { get; set; }

    public string? Addressline2 { get; set; }

    public string? Addressline3 { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Postcode { get; set; }

    public int? International { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Contact { get; set; }

    public string? Industrycodetype { get; set; }

    public string? Industry { get; set; }

    public string? Jobtitle { get; set; }

    public string? Occupationcodetype { get; set; }

    public string? Occupation { get; set; }

    public int? Shiftorirregularhoursworker { get; set; }

    public int? Salary { get; set; }

    public string? Duties { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual ICollection<ClmEmploymentcurrent> ClmEmploymentcurrents { get; set; } = new List<ClmEmploymentcurrent>();

    public virtual ICollection<ClmEmploymentdoi> ClmEmploymentdois { get; set; } = new List<ClmEmploymentdoi>();

    public virtual ClmempEmploymentSa? ClmempEmploymentSa { get; set; }

    public virtual OsOrgstructure? Orgstruct { get; set; }
}
