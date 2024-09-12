using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAOCPSEDB.Models;

namespace ClaimFormBusiness.Dtos
{
    public class ClmfrmClaimXDto : BaseDto
    {
        public string? Status { get; set; }
        public int? Whoisenteringclaimform { get; set; }
        public string? Workeremployeenumber { get; set; }
        public string? Workergivennames { get; set; }
        public string? Workerfamilyname { get; set; }
        public int? Workergender { get; set; }
        public DateTime? Workerbirthdate { get; set; }
        public string? Workeraddress1 { get; set; }
        public string? Workeraddress2 { get; set; }
        public string? Workeraddress3 { get; set; }
        public string? Workersuburb { get; set; }
        public string? Workerstate { get; set; }
        public string? Workerpostcode { get; set; }
        public string? Workermobilephone { get; set; }
        public string? Workerworkphone { get; set; }
        public string? Workeremail { get; set; }
        //public virtual OsOrgstructure? Orgstruct { get; set; }
        //public virtual ParParty? Workerparty { get; set; }
        //public virtual ICollection<ClmfrmClaimdocumentX> ClmfrmClaimdocumentXes { get; set; } = new List<ClmfrmClaimdocumentX>();
    }
}
