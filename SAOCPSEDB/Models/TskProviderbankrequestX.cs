﻿using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class TskProviderbankrequestX
{
    public int Taskstatus { get; set; }

    public string Clustertype { get; set; } = null!;

    public int Clusterid { get; set; }

    public string Tasktype { get; set; } = null!;

    public string? Taskdescription { get; set; }

    public int? Iconname { get; set; }

    public int Recordid { get; set; }

    public Guid Recordguid { get; set; }

    public int Userid { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Duedate { get; set; }

    public int? Datecompleted { get; set; }

    public int Completable { get; set; }

    public int? Extrainfo { get; set; }

    public byte[]? Compositeid { get; set; }
}
