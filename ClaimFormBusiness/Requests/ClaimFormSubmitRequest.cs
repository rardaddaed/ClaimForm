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
      List<Expression<Func<ClaimFormSubmitRequest, object>>> aaa = new List<Expression<Func<ClaimFormSubmitRequest, object>>>
    {
      x => x.ClmfrmClaimXDto.Status,
      x => x.ClmfrmClaimXDto.ClmfrmClaimdocumentXes
    };

      foreach (var x in aaa)
      {
        RuleFor(x).NotNull().WithMessage("");
      }

      RuleForGreaterThanOrEqualTo(x => x.ClmfrmClaimXDto.Whoisenteringclaimform, 10);
      Mandatory(x => x.ClmfrmClaimXDto.ClmfrmClaimdocumentXes, y => true);
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
