using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class BaseMedDate
{
    public int Medcertid { get; set; }

    public DateTime? Datefrom { get; set; }

    public DateTime? Dateto { get; set; }
}
