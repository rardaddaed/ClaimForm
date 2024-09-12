//using System.ComponentModel.DataAnnotations.Schema;
//using System.Globalization;
//using System.Linq.Expressions;
//using System.Reflection;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Serialization;
//using SAOCPSEDB.Models;
//using DateTime = System.DateTime;

//namespace SAOCPSEDB.ClaimForm.Logic
//{
//  public class ValidationResult
//  {
//    public string Field { get; set; }
//    public string ErrorMessage { get; set; }
//  }

//  public interface ILogicValidator
//  {
//    public void Update(bool checkValueChanges = false);
//    public List<ValidationResult> Validate();
//    public Dictionary<string, FormFieldAttributes> FormRules { get; }
//    public bool SetValue(string fieldName, object? value);
//    public void Save();
//    public Task SaveAsync();
//  }

//  public class FormFieldAttributes
//  {
//    public bool? Enabled { get; set; }
//    public bool? Mandatory { get; set; }
//    public int? MaxLength { get; set; }
//    public bool? Callback { get; set; }
//    public bool? Clear { get; set; }
//    public object? Value { get; set; } // Used to set front end value initially or after callback update / dialog selected, cannot be null that would be clear == true.
//    public List<KeyValuePair<string, string>>? Items { get; set; }
//    public string[]? SuburbDefinition { get; set; }

//    public static FormFieldAttributes? GetDeltaAttributes(FormFieldAttributes initial, FormFieldAttributes target)
//    {
//      var deltaAttributes = new FormFieldAttributes();
//      if (initial.Enabled != target.Enabled)
//        deltaAttributes.Enabled = target.Enabled;
//      if (initial.Mandatory != target.Mandatory)
//        deltaAttributes.Mandatory = target.Mandatory;
//      if (initial.MaxLength != target.MaxLength)
//        deltaAttributes.MaxLength = target.MaxLength;
//      if (initial.Callback != target.Callback)
//        deltaAttributes.Callback = target.Callback;
//      if (initial.Clear != target.Clear && target.Clear.GetValueOrDefault())
//        deltaAttributes.Clear = target.Clear;
//      if (initial.Value != target.Value && target.Value != null)
//        deltaAttributes.Value = target.Value;

//      if (target.Items != null && target.Items.Any())
//      {
//        if (initial.Items == null || !initial.Items.Any()) // Has target items but no source items so just set directly.
//          deltaAttributes.Items = target.Items;
//        else if (!ItemsEqual(initial.Items, target.Items)) // If items changed then should just redo them.
//          deltaAttributes.Items = target.Items;
//      }

//      if (target.SuburbDefinition != null && target.SuburbDefinition.Any())
//      {
//        if (initial.SuburbDefinition == null || !initial.SuburbDefinition.Any()) // Has target items but no source items so just set directly.
//          deltaAttributes.SuburbDefinition = target.SuburbDefinition;
//        else if (!ItemsEqual(initial.SuburbDefinition, target.SuburbDefinition)) // If items changed then should just redo them.
//          deltaAttributes.SuburbDefinition = target.SuburbDefinition;
//      }

//      var settings = new JsonSerializerSettings
//      {
//        ContractResolver = new CamelCasePropertyNamesContractResolver(),
//        Formatting = Formatting.Indented,
//        NullValueHandling = NullValueHandling.Ignore,
//      };

//      var formFieldJson = JsonConvert.SerializeObject(deltaAttributes, settings);
//      // Might want to do this in a more efficient way, maybe a boolean that starts at false and gets set to true if any of the fields gets set but for now this will work to remove empty objects from the delta.
//      // Well this will just return null but will handle nulls where this method is used.
//      if (string.IsNullOrWhiteSpace(formFieldJson) || formFieldJson == "{}")
//        return null;

//      return deltaAttributes;
//    }

//    public FormFieldAttributes()
//    {

//    }

//    public FormFieldAttributes(FormFieldAttributes source)
//    {
//      Enabled = source.Enabled;
//      Mandatory = source.Mandatory;
//      MaxLength = source.MaxLength;
//      Callback = source.Callback;
//      if (source.Clear.GetValueOrDefault())
//        Clear = source.Clear;
//      Items = source.Items; // Would have same reference issue.
//      Value = source.Value;
//      SuburbDefinition = source.SuburbDefinition;
//    }

//    public override bool Equals(object? obj)
//    {
//      if (obj is FormFieldAttributes other)
//      {
//        return Enabled == other.Enabled &&
//               Mandatory == other.Mandatory &&
//               MaxLength == other.MaxLength &&
//               Callback == other.Callback &&
//               Value == other.Value &&
//               Clear.GetValueOrDefault() == other.Clear.GetValueOrDefault() &&
//               ItemsEqual(Items, other.Items) &&
//               ItemsEqual(SuburbDefinition, other.SuburbDefinition);
//      }

//      return false;
//    }
//    private static bool ItemsEqual(List<KeyValuePair<string, string>>? items1, List<KeyValuePair<string, string>>? items2)
//    {
//      if (items1 == null && items2 == null) return true;
//      if (items1 == null || items2 == null) return false;
//      if (items1.Count != items2.Count) return false;

//      for (int i = 0; i < items1.Count; i++)
//      {
//        if (!items1[i].Key.Equals(items2[i].Key) || !items1[i].Value.Equals(items2[i].Value))
//          return false;
//      }
//      return true;
//    }
//    private static bool ItemsEqual(string[]? items1, string[]? items2)
//    {
//      if (items1 == null && items2 == null) return true;
//      if (items1 == null || items2 == null) return false;
//      if (items1.Length != items2.Length) return false;

//      for (int i = 0; i < items1.Length; i++)
//      {
//        if (!items1[i].Equals(items2[i]))
//          return false;
//      }
//      return true;
//    }

//    public override int GetHashCode()
//    {
//      int hashCode = 17;
//      hashCode = hashCode * 23 + Enabled.GetHashCode();
//      hashCode = hashCode * 23 + Mandatory.GetHashCode();
//      hashCode = hashCode * 23 + MaxLength.GetHashCode();
//      hashCode = hashCode * 23 + Callback.GetHashCode();
//      hashCode = hashCode * 23 + Clear.GetHashCode();
//      hashCode = hashCode * 23 + Value.GetHashCode();
//      if (Items != null)
//      {
//        foreach (var item in Items)
//        {
//          hashCode = hashCode * 23 + item.GetHashCode();
//        }
//      }
//      if (SuburbDefinition != null)
//      {
//        foreach (var item in SuburbDefinition)
//        {
//          hashCode = hashCode * 23 + item.GetHashCode();
//        }
//      }
//      return hashCode;
//    }
//  }

//  public abstract class LogicValidator<TTable> : ILogicValidator where TTable : class, new()
//  {
//    public TTable Data { get; set; }
//    public TTable _cachedData { get; set; }
//    public Dictionary<string, FormFieldAttributes> FormRules { get; } = new();
//    public Dictionary<string, (string State, string Postcode)> SuburbDefinitions { get; } = new();
//    public bool SetValue(string fieldName, object? value)
//    {
//      if (fieldName == null)
//        throw new ArgumentNullException(nameof(fieldName));

//      if (!HasProperty(Data, fieldName.ToLower()))
//      {
//        TextInfo info = CultureInfo.CurrentCulture.TextInfo;
//        fieldName = info.ToTitleCase(fieldName.ToLower());
//        if (!HasProperty(Data, fieldName))
//          return false;
//      }

//      PropertyInfo property = Data.GetType().GetProperty(fieldName);

//      if (property == null)
//        return false;

//      if (SuburbDefinitions.TryGetValue(property.Name, out var statePostcodePropertyNames))
//      {
//        var newSuburbText = value?.ToString();
//        if (string.IsNullOrWhiteSpace(newSuburbText) || newSuburbText.Length < 2)
//          return true;

//        using var db = new SbcDbContext();

//        var suburbs = db.Postcodes.Where(x => x.Suburb!.StartsWith(newSuburbText)).Take(25);
//        // SetValue(statePostcodePropertyNames.State, suburbs)
//        // FormRules[property.Name].Items = suburbs.Select(x => new KeyValuePair<string, string>($"{x.Suburb!.Trim()}={x.State!.Trim()}={x.Postcode1!.Trim()}", $"{x.Suburb!.Trim()} {x.State!.Trim()} {x.Postcode1!.Trim()}")).ToList();
//        var foundSuburbs = suburbs.Select(x => new KeyValuePair<string, string>($"{x.Suburb!.Trim()} {x.State!.Trim()} {x.Postcode1!.Trim()}", "")).ToList();
//        FormRules[property.Name].Items = foundSuburbs;

//        // Possibly Temporary, returning here will prevent client side from being able to set the value of suburb definitions on backend. - EXACTLY???
//        // return true;
//      }

//      if (property != null && property.CanWrite)
//      {
//        try
//        {
//          Type propertyType = property.PropertyType;

//          if (value == null || value.ToString() == "undefined" || value.ToString() == "null")
//            property.SetValue(Data, null);
//          else if (propertyType == typeof(short))
//          {
//            if (value == null)
//              property.SetValue(Data, null);
//            else if (value is int intValue)
//              property.SetValue(Data, intValue);
//            else if (value.ToString()?.ToLower() == "true" || value.ToString()?.ToLower() == "false")
//              property.SetValue(Data, Convert.ToBoolean(value.ToString()?.ToLower()) ? (short)1 : (short)0);
//            else
//              property.SetValue(Data, Convert.ToInt16(value.ToString()));
//          }
//          else if (propertyType == typeof(short?))
//          {
//            if (value == null)
//              property.SetValue(Data, null);
//            else if (value is int nullableIntValue)
//              property.SetValue(Data, nullableIntValue);
//            else if (value.ToString()?.ToLower() == "true" || value.ToString()?.ToLower() == "false")
//              property.SetValue(Data, Convert.ToBoolean(value.ToString()?.ToLower()) ? (short)1 : (short)0);
//            else
//              property.SetValue(Data, Convert.ToInt16(value.ToString()));
//          }
//          else if (propertyType == typeof(int))
//          {
//            if (value == null)
//              throw new ArgumentNullException(nameof(value), nameof(value) + " is null but property type is non nullable int");
//            else if (value is int intValue)
//              property.SetValue(Data, intValue);
//            else if (value.ToString()?.ToLower() == "true" || value.ToString()?.ToLower() == "false")
//              property.SetValue(Data, Convert.ToBoolean(value.ToString()?.ToLower()) ? 1 : 0);
//            else
//              property.SetValue(Data, Convert.ToInt32(value.ToString()));
//          }
//          else if (propertyType == typeof(int?))
//          {
//            if (value == null)
//              property.SetValue(Data, null);
//            else if (value is int nullableIntValue)
//              property.SetValue(Data, nullableIntValue);
//            else if (value.ToString()?.ToLower() == "true" || value.ToString()?.ToLower() == "false")
//              property.SetValue(Data, Convert.ToBoolean(value.ToString()?.ToLower()) ? 1 : 0);
//            else
//              property.SetValue(Data, Convert.ToInt32(value.ToString()));
//          }
//          else if (propertyType == typeof(decimal))
//          {
//            if (value == null)
//              throw new ArgumentNullException(nameof(value), nameof(value) + " is null but property type is non nullable decimal");
//            else if (value is decimal decimalValue)
//              property.SetValue(Data, decimalValue);
//            else if (value.ToString()?.ToLower() == "true" || value.ToString()?.ToLower() == "false")
//              property.SetValue(Data, Convert.ToBoolean(value.ToString()?.ToLower()) ? 1 : 0);
//            else
//              property.SetValue(Data, Convert.ToDecimal(value.ToString()));
//          }
//          else if (propertyType == typeof(decimal?))
//          {
//            if (string.IsNullOrWhiteSpace(value.ToString()))
//              property.SetValue(Data, null);
//            else if (value is decimal nullableDecimalValue)
//              property.SetValue(Data, nullableDecimalValue);
//            else if (value.ToString()?.ToLower() == "true" || value.ToString()?.ToLower() == "false")
//              property.SetValue(Data, Convert.ToBoolean(value.ToString()?.ToLower()) ? 1 : 0);
//            else
//              property.SetValue(Data, Convert.ToDecimal(value.ToString()));
//          }
//          else if (propertyType == typeof(DateTime) || propertyType == typeof(DateTime?))
//          {
//            if (value == null)
//              property.SetValue(Data, null);
//            else if (string.IsNullOrWhiteSpace(value.ToString()))
//              property.SetValue(Data, null);
//            else if (value is DateTime valueDateTime)
//              property.SetValue(Data, valueDateTime);
//            else
//              property.SetValue(Data, Convert.ToDateTime(value.ToString()));
//          }
//          else if (propertyType == typeof(string))
//            property.SetValue(Data, value?.ToString());
//          else if (value == null)
//            property.SetValue(Data, value);
//          else
//            property.SetValue(Data, value.ToString());

//          object newValue = property.GetValue(Data);
//          return true;
//        }
//        catch (Exception ex)
//        {
//          Console.WriteLine($"Error setting property: {ex.Message}");
//          return false;
//        }
//      }

//      // if(property.Name.ToLower().EndsWith("suburb"))

//      return false;
//    }

//    private SbcDbContext Context { get; set; }

//    public LogicValidator(SbcDbContext context, TTable? data)
//    {
//      Context = context;
//      if (data == null)
//      {
//        Data = new TTable();
//        _cachedData = new TTable();
//      }
//      else
//      {
//        Data = data;
//        _cachedData = new TTable();
//      }
//    }

//    protected void SetFormFieldAttributes<TProperty>(Expression<Func<TTable, TProperty>> expression, Action<FormFieldAttributes> configureAction)
//    {
//      if (expression.Body is NewExpression newExpression) // Is the body of the expression like x => new {}
//      {
//        foreach (var argument in newExpression.Arguments)
//        {
//          if (argument is MemberExpression memberExpression)
//          {
//            string propertyName = memberExpression.Member.Name;
//            if (!FormRules.TryGetValue(propertyName, out var attributes))
//            {
//              attributes = new FormFieldAttributes();
//              FormRules[propertyName] = attributes;
//            }
//            configureAction(attributes);
//            if (attributes.Clear.GetValueOrDefault())
//              SetValue(propertyName, null);
//          }
//          else
//          {
//            throw new ArgumentException("Expression arguments must be member expressions");
//          }
//        }
//      }
//      else if (expression.Body is MemberExpression memberExpression)
//      {
//        string propertyName = memberExpression.Member.Name;
//        if (!FormRules.TryGetValue(propertyName, out var attributes))
//        {
//          attributes = new FormFieldAttributes();
//          FormRules[propertyName] = attributes;
//        }
//        configureAction(attributes);
//      }
//      else
//      {
//        throw new ArgumentException("Expression must be a member expression");
//      }
//    }

//    public void Mandatory<TProperty>(Expression<Func<TTable, TProperty>> expression, bool value = true)
//    {
//      SetFormFieldAttributes(expression, attributes =>
//      {
//        attributes.Mandatory = value;
//      });
//    }

//    public void Mandatory<TProperty>(Expression<Func<TTable, TProperty>> expression, Expression<Func<TTable, bool>> condition)
//    {
//      SetFormFieldAttributes(expression, attributes =>
//      {
//        attributes.Mandatory = condition.Compile()(Data);
//      });

//      bool calledFromUpdate = IsCalledFromUpdate();
//      if (calledFromUpdate)
//      {
//        var conditionFields = GetReferencedProperties(condition);
//        foreach (var propertyName in conditionFields)
//        {
//          if (!FormRules.TryGetValue(propertyName, out var attributes))
//          {
//            attributes = new FormFieldAttributes();
//            FormRules[propertyName] = attributes;
//          }
//          attributes.Callback = true;
//        }
//      }
//    }

//    public void Enable<TProperty>(Expression<Func<TTable, TProperty>> expression, bool value = true, bool? clear = null)
//    {
//      bool calledFromUpdate = IsCalledFromUpdate();
//      SetFormFieldAttributes(expression, attributes =>
//      {
//        attributes.Enabled = value;
//        attributes.Clear = clear ?? !value;
//        if (calledFromUpdate)
//          attributes.Callback = true;
//      });
//    }

//    public void Enable<TProperty>(Expression<Func<TTable, TProperty>> expression, Expression<Func<TTable, bool>> condition, Expression<Func<TTable, bool>>? clearCondition = null)
//    {
//      bool calledFromUpdate = IsCalledFromUpdate();
//      SetFormFieldAttributes(expression, attributes =>
//      {
//        attributes.Enabled = condition.Compile()(Data);
//        if (clearCondition != null)
//          attributes.Clear = clearCondition.Compile()(Data);
//        else
//          attributes.Clear = !attributes.Enabled;
//      });

//      if (calledFromUpdate)
//      {
//        var conditionFields = GetReferencedProperties(condition);
//        foreach (var propertyName in conditionFields)
//        {
//          if (!FormRules.TryGetValue(propertyName, out var attributes))
//          {
//            attributes = new FormFieldAttributes();
//            FormRules[propertyName] = attributes;
//          }
//          attributes.Callback = true;
//        }
//      }
//    }

//    public void EnableAndMandatory<TProperty>(Expression<Func<TTable, TProperty>> expression, Expression<Func<TTable, bool>> condition)
//    {
//      Enable(expression, condition);
//      Mandatory(expression, condition);
//    }

//    public void SetItems<TProperty>(Expression<Func<TTable, TProperty>> expression, IEnumerable<KeyValuePair<string, string>> keyValues)
//    {
//      SetFormFieldAttributes(expression, attributes =>
//      {
//        attributes.Items = new List<KeyValuePair<string, string>>();
//        attributes.Items.AddRange(keyValues);
//      });
//    }

//    public void SetCodeType<TProperty>(Expression<Func<TTable, TProperty>> expression, string codeType, int? zone = null)
//    {
//      SetFormFieldAttributes(expression, attributes =>
//      {
//        attributes.Items = new List<KeyValuePair<string, string>>();
//        var codes = Context.Zprimarycodes.Where(x => x.Zone == zone.GetValueOrDefault() && x.CodeType == codeType).OrderBy(x => x.DisplayValue); // TODO: THIS IS TEMPORARY. Doesn't consider sooo many things.
//        attributes.Items.AddRange(codes.Select(x => new KeyValuePair<string, string>(x.CodeValue.Trim(), (x.DisplayValue ?? "").Trim())).ToList());
//      });
//    }

//    public void MaxLength<TProperty>(Expression<Func<TTable, TProperty>> expression, int maxLength)
//    {
//      SetFormFieldAttributes(expression, attributes =>
//      {
//        attributes.MaxLength = maxLength;
//      });
//    }
//    public void DefineSuburb<TProperty>(Expression<Func<TTable, TProperty>> expression)
//    {
//      if (expression.Body is NewExpression newExpression) // Is the body of the expression like x => new {}
//      {
//        if (newExpression.Arguments.FirstOrDefault(x => (x as MemberExpression)?.Member.Name.ToLower().EndsWith("suburb") == true) is not MemberExpression suburbField)
//          throw new ArgumentNullException("Suburb", "Suburb field could not be found in expression");

//        if (newExpression.Arguments.FirstOrDefault(x => (x as MemberExpression)?.Member.Name.ToLower().EndsWith("state") == true) is not MemberExpression stateField)
//          throw new ArgumentNullException("State", "State field could not be found in expression");

//        if (newExpression.Arguments.FirstOrDefault(x => (x as MemberExpression)?.Member.Name.ToLower().EndsWith("postcode") == true) is not MemberExpression postcodeField)
//          throw new ArgumentNullException("Postcode", "Postcode field could not be found in expression");

//        SuburbDefinitions.Add(suburbField.Member.Name, (stateField.Member.Name, postcodeField.Member.Name));
//        var suburbDefinitions = new[] { suburbField.Member.Name.ToLower(), stateField.Member.Name.ToLower(), postcodeField.Member.Name.ToLower() };

//        if (!FormRules.TryGetValue(suburbField.Member.Name, out var suburbAttributes))
//        {
//          suburbAttributes = new FormFieldAttributes();
//          FormRules[suburbField.Member.Name] = suburbAttributes;
//        }
//        suburbAttributes.SuburbDefinition = suburbDefinitions;

//      }
//    }

//    /*public string ToJson()
//    {
//        var settings = new JsonSerializerSettings
//        {
//            ContractResolver = new CamelCasePropertyNamesContractResolver(),
//            Formatting = Formatting.Indented
//        };

//        var json = JsonConvert.SerializeObject(FormRules, settings);

//        return json;
//    }
//    */

//    public virtual void Update(bool checkValueChanges = false)
//    {
//      if (checkValueChanges)
//      {
//        foreach (var property in typeof(TTable).GetProperties())
//        {
//          var propertyName = property.Name;
//          bool hasNotMappedAttribute = property.GetCustomAttributes(typeof(NotMappedAttribute), false).Any();
//          if (hasNotMappedAttribute)
//            continue;
//          if (property.GetSetMethod() != null && FormRules.TryGetValue(propertyName, out var attributes))
//          {
//            var value = property.GetValue(Data);
//            var cachedValue = property.GetValue(_cachedData);

//            if (value?.ToString() != cachedValue?.ToString())
//            {
//              // FormRules[propertyName].Value = value;
//              attributes.Value = value;
//              property.SetValue(_cachedData, value);
//            }
//          }
//        }
//      }
//    }

//    public virtual List<ValidationResult> CustomValidate(List<ValidationResult> errors)
//    {
//      return errors;
//    }

//    public List<ValidationResult> Validate()
//    {
//      var validationResults = new List<ValidationResult>();

//      foreach (var property in typeof(TTable).GetProperties())
//      {
//        var propertyName = property.Name;
//        if (FormRules.TryGetValue(propertyName, out var attributes))
//        {
//          var value = property.GetValue(Data);

//          // Mandatory rule
//          if (attributes.Mandatory.GetValueOrDefault() && (value == null || string.IsNullOrWhiteSpace(value.ToString())))
//          {
//            validationResults.Add(new ValidationResult
//            {
//              Field = propertyName,
//              ErrorMessage = $"{propertyName} is mandatory."
//            });
//          }

//          // TODO: other rules
//        }
//      }

//      CustomValidate(validationResults);

//      return validationResults;
//    }

//    public void Save()
//    {
//      try
//      {
//        using var db = new SbcDbContext();
//        db.Entry(Data).State = EntityState.Added;
//        db.SaveChanges();
//      }
//      catch (Exception ex)
//      {
//        var temp = ex;
//      }
//    }
//    public async Task SaveAsync()
//    {
//      try
//      {
//        await using var db = new SbcDbContext();
//        db.Entry(Data).State = EntityState.Added;
//        await db.SaveChangesAsync();
//      }
//      catch (Exception ex)
//      {
//        var temp = ex;
//      }
//    }

//    private bool IsCalledFromUpdate()
//    {
//      var stackTrace = new System.Diagnostics.StackTrace();
//      var frames = stackTrace.GetFrames();
//      if (frames != null)
//      {
//        foreach (var frame in frames)
//        {
//          var method = frame.GetMethod();
//          if (method != null && method.Name == "Update")
//          {
//            return true;
//          }
//        }
//      }
//      return false;
//    }

//    private IEnumerable<string> GetReferencedProperties(Expression expression)
//    {
//      var visitor = new MemberAccessVisitor();
//      visitor.Visit(expression);
//      return visitor.MemberNames;
//    }

//    private class MemberAccessVisitor : ExpressionVisitor
//    {
//      public HashSet<string> MemberNames { get; } = new HashSet<string>();

//      protected override Expression VisitMember(MemberExpression node)
//      {
//        if (node.Member.MemberType == System.Reflection.MemberTypes.Property)
//        {
//          MemberNames.Add(node.Member.Name);
//        }
//        return base.VisitMember(node);
//      }
//    }
//    public static bool HasProperty(object obj, string propertyName)
//    {
//      if (obj == null) throw new ArgumentNullException(nameof(obj));
//      if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));

//      Type type = obj.GetType();
//      PropertyInfo property = type.GetProperty(propertyName);
//      return property != null;
//    }
//  }
//}
