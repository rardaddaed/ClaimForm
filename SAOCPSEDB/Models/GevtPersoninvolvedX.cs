using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class GevtPersoninvolvedX
{
    public int Geventid { get; set; }

    public int Personinvolvedno { get; set; }

    public string? Persontype { get; set; }

    public int? Hrid { get; set; }

    public string? Clientid { get; set; }

    public string? Employeeno { get; set; }

    public string? Nonemployeetype { get; set; }

    public string? Gender { get; set; }

    public string? Givennames { get; set; }

    public string? Familyname { get; set; }

    public string? Emailaddress { get; set; }

    public string? Contactnumber { get; set; }

    public string? Occupation { get; set; }

    public string? Workstatus { get; set; }

    public string? Percentofshiftcomplete { get; set; }

    public short? Affectedbyfatigue { get; set; }

    public string? Initialtreatmenttype { get; set; }

    public string? Descriptionoftreatment { get; set; }

    public string? Injury { get; set; }

    public string? Subjectofcomplaint { get; set; }

    public string? Relationshiptosubject { get; set; }

    public string? Involvement { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string? Injuryside { get; set; }

    public string? Bodilylocationl2 { get; set; }

    public string? Descriptionofinjury { get; set; }

    public short? Workceased { get; set; }

    public DateTime? Dateworkceased { get; set; }

    public DateTime? Timeworkceased { get; set; }

    public string? Clientnumber { get; set; }

    public virtual GevtEventX Gevent { get; set; } = null!;
}
