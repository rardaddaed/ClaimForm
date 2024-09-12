using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaimFormBusiness.Dtos;
using ClaimFormBusiness.Repositories;
using MediatR;
using FluentValidation;
using ClaimFormBusiness.Validators;
using System.Linq.Expressions;

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

  public class ClaimFormSubmitValidator : BaseValidator<ClaimFormSubmitRequest>
  {
    public ClaimFormSubmitValidator()
    {
      RuleForGreaterThanOrEqualTo(x => x.ClmfrmClaimXDto.Whoisenteringclaimform, 10);
      Mandatory(x => x.ClmfrmClaimXDto.Workeraddress1, y => y.ClmfrmClaimXDto.Workergender == 0);
    }
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
