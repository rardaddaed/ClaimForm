//using System.Collections;
//using Microsoft.AspNetCore.Mvc;
//using SAOCPSEDB.ClaimForm.Dialogs;
//using SAOCPSEDB.ClaimForm.Forms;
//using SAOCPSEDB.Models;
//using SAOCPSEDB.Models.Auxiliary;

//namespace ClaimFormApi.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class BSBSearchDialogController : ControllerBase
//    {
//        // TEMP FOR TESTING. THIS MEANS ONLY ONE USER CAN SEARCH BSB AT A TIME
//        public static BSBSearchDialog BsbSearchDialog { get; set; }
//        private readonly SbcDbContext _context;

//        public BSBSearchDialogController(SbcDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public IEnumerable GetInit()
//        {
//            BsbSearchDialog = new BSBSearchDialog();
//            return BsbSearchDialog.ToJson();
//        }

//        [HttpPost("Callback")]
//        public IEnumerable PostCallback(CallbackDto callback)
//        {
//            BsbSearchDialog.Update(callback);
//            return BsbSearchDialog.GetJsonDelta();
//        }

//        [HttpPost]
//        public IEnumerable GetSearch([FromForm] AuxBsbsearch criteria)
//        {
//            BsbSearchDialog.Update(criteria);
//            if (criteria.Bsbone == null)
//                return null;
//            return BsbSearchDialog.GetSearchResults();
//        }
//    }
//}
