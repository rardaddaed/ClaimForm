using ClaimFormBusiness.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimFormBusiness.Repositories
{
    public interface IClaimFormRepository
    {
        Task SubmitClaimForm(ClmfrmClaimXDto clmfrmClaimXDto, CancellationToken cancellationToken);
    }
}
