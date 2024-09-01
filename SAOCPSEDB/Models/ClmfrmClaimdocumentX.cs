namespace SAOCPSEDB.Models;

public partial class ClmfrmClaimdocumentX
{
    public int Claimformid { get; set; }

    public int Claimdocumentno { get; set; }

    public int? Documentid { get; set; }

    public string? Description { get; set; }

    public DateTime? Recorddateentered { get; set; }

    public int? Recordenteredby { get; set; }

    public DateTime? Recorddatemodified { get; set; }

    public Guid Guid { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public short? Isclaimform { get; set; }

    public virtual ClmfrmClaimX Claimform { get; set; } = null!;

    public virtual DmsDocument? Document { get; set; }
}
