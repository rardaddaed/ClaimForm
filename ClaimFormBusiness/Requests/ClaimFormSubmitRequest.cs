using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimFormBusiness.Dtos;
using ClaimFormBusiness.Repositories;
using MediatR;
using FluentValidation;

namespace ClaimFormBusiness.Requests
{
    public class ClaimFormSubmitRequest : IRequest<Unit>
    {
        public ClaimFormSubmitRequest(ClmfrmClaimXDto clmfrmClaimXDto)
        {
            ClmfrmClaimXDto = clmfrmClaimXDto;
        }
        public ClmfrmClaimXDto ClmfrmClaimXDto { get; }

    }

    public class ClaimFormSubmitRequestHandler : IRequestHandler<ClaimFormSubmitRequest, Unit>
    {
        private readonly IClaimFormRepository ClaimFormRepository;

        public ClaimFormSubmitRequestHandler(IClaimFormRepository claimFormRepository)
        {
            ClaimFormRepository = claimFormRepository;
        }

        public async Task<Unit> Handle(ClaimFormSubmitRequest request, CancellationToken cancellationToken)
        {
            await ClaimFormRepository.SubmitClaimForm(request.ClmfrmClaimXDto, cancellationToken);

            return Unit.Value;
        }
    }
}
