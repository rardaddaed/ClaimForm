using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClaimFormBusiness.Validators
{
  public abstract class BaseValidator<T> : AbstractValidator<T>, IValidator<T>
  {
    public IRuleBuilderOptions<T, int?> RuleForGreaterThanOrEqualTo(Expression<Func<T, int?>> propertyAccessor, int? value) 
    {
      return RuleFor(propertyAccessor)
        .Must(v => (v.HasValue && v.Value >= value) || !v.HasValue)
        .WithMessage($"Must be greater than or equal to {value}");
    }

    public IRuleBuilderOptions<T, DateTime> RuleForDateInclusiveBetween(Expression<Func<T, DateTime>> propertyAccessor, DateTime startDate, DateTime endDate)
    {
      return RuleFor(propertyAccessor)
        .InclusiveBetween(startDate, endDate)
        .WithMessage("");
    }
    
    public IRuleBuilderOptions<T, TProp> Mandatory<TProp>(Expression<Func<T, TProp>> propertyAccessor, Func<T, bool> condition)
    {
      //return When(x => condition(x), () => RuleFor(propertyAccessor).NotNull());
      return RuleFor(propertyAccessor).NotNull()
        .When(condition);
    }

    public IRuleBuilderOptions<T, TProp> Mandatory<TProp>(Expression<Func<T, TProp>> propertyAccessor)
    {
      return RuleFor(propertyAccessor).NotNull();
    }
    //public IRuleBuilderOptionsConditions<T, string> RuleForComplicated(Expression<Func<T, string>> propertyAccessor)
    //{
    //  return RuleFor(propertyAccessor)
    //    .CustomAsync( async (p, context, cancellationToken) =>
    //    {

    //    });
    //}
  }
}
