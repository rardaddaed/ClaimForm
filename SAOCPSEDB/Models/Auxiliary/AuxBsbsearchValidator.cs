using SAOCPSEDB.ClaimForm.Logic;

namespace SAOCPSEDB.Models.Auxiliary
{
    public class AuxBsbsearchValidator : LogicValidator<AuxBsbsearch>
    {
        public AuxBsbsearchValidator(SbcDbContext context, AuxBsbsearch? data) : base (context, data)
        {
            Enable(x => new {x.Bsbone, x.Bsbtwo, x.Institution, x.Address, x.Suburb, x.State, x.Postcode});
            MaxLength(x => new { x.Bsbone, x.Bsbtwo }, 3);
            // Bsbone.NegativeNumbers = false;
            // Bsbtwo.NegativeNumbers = false;
            // Bsbone.ClientName = "BSB section 1";
            // Bsbtwo.ClientName = "BSB section 2";
            SetCodeType(x => x.Institution, "BANK");
        }
    }

}
