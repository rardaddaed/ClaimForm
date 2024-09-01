using System;
using System.Collections.Generic;

namespace SAOCPSEDB.Models;

public partial class AdmEmailtemplatedocument
{
    public int Emailtemplateid { get; set; }

    public int Templatedocumentno { get; set; }

    public int? Documentid { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }

    public virtual AdmEmailtemplate Emailtemplate { get; set; } = null!;
}
