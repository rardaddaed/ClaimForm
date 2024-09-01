using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class BaseTskWorkflowalert
{
    public int Taskstatus { get; set; }

    public string? Clustertype { get; set; }

    public int? Clusterid { get; set; }

    public string? TaskType { get; set; }

    public string? Taskdescription { get; set; }

    public string Iconname { get; set; } = null!;

    public int Recordid { get; set; }

    public Guid? Recordguid { get; set; }

    public int Userid { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? Datecompleted { get; set; }

    public int Completable { get; set; }

    public string? Extrainfo { get; set; }

    public byte[]? Compositeid { get; set; }
}
