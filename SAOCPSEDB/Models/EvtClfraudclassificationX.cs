﻿using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class EvtClfraudclassificationX
{
    public int Eventid { get; set; }

    public int Classificationno { get; set; }

    public string? Fraudtype { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual EvtEventX1 Event { get; set; } = null!;
}
