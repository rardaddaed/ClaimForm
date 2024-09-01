using Microsoft.EntityFrameworkCore;
using SAOCPSEDB.Models;

namespace SAOCPSEDB.ClaimForm.Forms.Claim
{
    public class ClaimDetailsForm: AbstractForm
    {
        public ClmfrmClaimX Claim { get; set; } = new ();
        public ICollection<ClmfrmClaimdocumentX> Documents => Claim.ClmfrmClaimdocumentXes;
        public OsOrgstructure OrganisationStructure => Claim.Orgstruct ?? (Claim.Orgstruct = new OsOrgstructure());
        public OsOrgstructureX OrganisationStructureX => OrganisationStructure.OsOrgstructureX ?? (OrganisationStructure.OsOrgstructureX = new OsOrgstructureX());

        public ClaimDetailsForm(SbcDbContext context)
        {
            Bind(Claim, context);
            Bind(Documents, context);
            Bind(OrganisationStructure, context);
            Bind(OrganisationStructureX, context);
        }

        public override async Task SaveAsync()
        {
            try
            {
                await using var db = new SbcDbContext();
                Claim.Status = "SUBMITTED";
                Claim.Statusdate = DateTime.Today;
                db.Entry(Claim).State = EntityState.Added;
                db.ClmfrmClaimXes.Add(Claim);
                if (Claim.Orgstruct != null)
                {
                    db.OsOrgstructures.Add(Claim.Orgstruct);
                    db.Entry(Claim.Orgstruct).State = EntityState.Added;
                    if (Claim.Orgstruct.OsOrgstructureX != null)
                    {
                        db.OsOrgstructureXes.Add(Claim.Orgstruct.OsOrgstructureX);
                        db.Entry(Claim.Orgstruct.OsOrgstructureX).State = EntityState.Added;
                    }
                }

                if (Claim.ClmfrmClaimdocumentXes.Any())
                {
                    // db.ClmfrmClaimdocumentXes.AddRange(Claim.ClmfrmClaimdocumentXes);
                    foreach (var clmDoc in Claim.ClmfrmClaimdocumentXes)
                    {
                        db.Entry(clmDoc).State = EntityState.Added;
                        if (clmDoc.Document != null)
                        {
                            db.Entry(clmDoc.Document).State = EntityState.Added;
                            if (clmDoc.Document.DmsRevisions.Any())
                            {
                                foreach (var revision in clmDoc.Document.DmsRevisions)
                                {
                                    db.Entry(revision).State = EntityState.Added;
                                    if(revision.DmsRevisionfile != null)
                                        db.Entry(revision.DmsRevisionfile).State = EntityState.Added;
                                }
                            }
                        }
                        
                    }
                }

                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var temp = ex;
            }

        }
    }
}
