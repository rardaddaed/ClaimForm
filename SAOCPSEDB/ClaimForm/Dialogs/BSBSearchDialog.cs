//using SAOCPSEDB.ClaimForm.Forms.Claim;
//using SAOCPSEDB.Models;
//using SAOCPSEDB.Models.Auxiliary;

//namespace SAOCPSEDB.ClaimForm.Dialogs
//{
//    public class BSBSearchDialog : AbstractForm
//    {
//        public AuxBsbsearch Criteria { get; set; } = new();

//        public BSBSearchDialog()
//        {
//            using var context = new SbcDbContext();
//            Bind(Criteria, context);
//        }

//        // This should probably be refactored in future to only select columns we want so don't need `.Select` and also don't need the original table.
//        // Also should probably use dto's for static typing 
//        public dynamic GetSearchResults()
//        {
//            using var context = new SbcDbContext();

//            IQueryable<BsbBranch> query = context.BsbBranches;
//            if (query == null)
//                throw new InvalidOperationException("Operation has been aborted because db context was not able to find the table");

//            if (!string.IsNullOrEmpty(Criteria.Bsbone))
//                query = query.Where(x => x.Bsb1 == Criteria.Bsbone);

//            if (!string.IsNullOrEmpty(Criteria.Bsbtwo))
//                query = query.Where(x => x.Bsb2 == Criteria.Bsbtwo);

//            if (!string.IsNullOrEmpty(Criteria.Institution))
//                query = query.Where(x => x.Bank == Criteria.Institution);

//            if (!string.IsNullOrEmpty(Criteria.Address))
//                query = query.Where(x => (x.Address ?? string.Empty).Contains(Criteria.Address)); // Check if case sensitivity matters.

//            if (!string.IsNullOrEmpty(Criteria.Suburb))
//                query = query.Where(x => (x.Suburb ?? string.Empty).Contains(Criteria.Suburb));

//            if (!string.IsNullOrEmpty(Criteria.State))
//                query = query.Where(x => (x.State ?? string.Empty).Contains(Criteria.State));

//            if (!string.IsNullOrEmpty(Criteria.Postcode))
//                query = query.Where(x => (x.Postcode ?? string.Empty).Contains(Criteria.Postcode));

//            var banks = new List<dynamic>();

//            foreach (var bsbBranch in query.ToList())
//            {
//                var bank = ((context.Zprimarycodes.FirstOrDefault(c => c.Zone == 0 && c.CodeType == "BANK" && c.CodeValue == bsbBranch.Bank) ?? new Zprimarycode()).DisplayValue ?? string.Empty).Trim();
//                banks.Add(new
//                {
//                    bsbBranch.Bsbid,
//                    Bsb = bsbBranch.Bsb1 + " - " + bsbBranch.Bsb2,
//                    Bank = bank.Trim(),
//                    bsbBranch.Address,
//                    bsbBranch.Suburb,
//                    bsbBranch.State,
//                    bsbBranch.Postcode
//                });
//            }

//            return banks;
//        }
//    }
//}
