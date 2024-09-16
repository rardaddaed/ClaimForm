using FluentValidation;
using Microsoft.IdentityModel.Tokens;
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

    public void Mandatory<TProp>(Expression<Func<T, TProp>> propertyAccessor, Func<T, bool> condition)
    {
      RuleFor(propertyAccessor).NotNull().WithMessage("{PropertyName} is mandatory.")
        .When(condition);
    }

    public void Mandatory<TProp>(Expression<Func<T, TProp>> propertyAccessor)
    {
      RuleFor(propertyAccessor).NotNull().WithMessage("{PropertyName} is mandatory.");
    }

    public void DefineSuburb(Expression<Func<T, string>> stateExpression, Expression<Func<T, string>> suburbExpression, Expression<Func<T, string>> postcodeExpression)
    {
      RuleFor(stateExpression).MaximumLength(3).WithMessage("State must be less than 3 characters.")
        .When(s => !string.IsNullOrEmpty(GetPropertyValue(stateExpression, s)));
      RuleFor(postcodeExpression).MaximumLength(4).WithMessage("Postcode must be less than 4 characters.")
        .When(p => !string.IsNullOrEmpty(GetPropertyValue(stateExpression, p)));
    }
    private string? GetPropertyValue<TProp>(Expression<Func<T, TProp>> expression, T instance)
    {
      var memberExpression = (MemberExpression)expression.Body;
      var propertyInfo = (System.Reflection.PropertyInfo)memberExpression.Member;
      return (string?)propertyInfo.GetValue(instance);
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
