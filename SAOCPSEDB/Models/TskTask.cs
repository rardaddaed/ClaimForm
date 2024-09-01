using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class TskTask
{
    public int Taskid { get; set; }

    public short? Taskstatus { get; set; }

    public string? Clustertype { get; set; }

    public int? Clusterid { get; set; }

    public string? Tasktype { get; set; }

    public string? Taskdescription { get; set; }

    public string? Iconname { get; set; }

    public int? Recordid { get; set; }

    public Guid? Recordguid { get; set; }

    public int? Userid { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Duedate { get; set; }

    public DateTime? Datecompleted { get; set; }

    public short? Completable { get; set; }

    public string? Extrainfo { get; set; }

    public byte[]? Compositeid { get; set; }

    public Guid? Guid { get; set; }

    public byte[]? Timestamp { get; set; }
}
