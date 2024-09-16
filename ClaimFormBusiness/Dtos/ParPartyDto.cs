using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimFormBusiness.Dtos
{
  public class ParPartyDto : BaseDto
  {
    public string? Partytype { get; set; }
    public int? Active { get; set; }
    public string? Familyname { get; set; }
    public string? Givennames { get; set; }
    public string? Preferredname { get; set; }
  }
}
