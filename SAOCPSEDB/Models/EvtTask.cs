using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtTask
{
    public string RecordType { get; set; } = null!;

    public int RecordId { get; set; }

    public int? SubRecordId { get; set; }

    public string? Reference { get; set; }

    public string ActionType { get; set; } = null!;

    public int? Responsible { get; set; }

    public DateTime? TargetDate { get; set; }

    public string? Description { get; set; }
}
