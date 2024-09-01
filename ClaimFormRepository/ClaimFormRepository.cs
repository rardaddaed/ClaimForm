using AutoMapper;
using ClaimFormBusiness.Dtos;
using ClaimFormBusiness.Repositories;
using SAOCPSEDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimFormRepository
{
  public class ClaimFormRepository : BaseRepository, IClaimFormRepository
  {
    public ClaimFormRepository(SbcDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }
    public async Task SubmitClaimForm(ClmfrmClaimXDto clmfrmClaimXDto, CancellationToken cancellationToken)
    {
      await AddModelAsync(DbContext.ClmfrmClaimXes, clmfrmClaimXDto);
    }
  }
}
