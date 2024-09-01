using SAOCPSEDB.ClaimForm.Logic;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SAOCPSEDB.Models;
using Microsoft.AspNetCore.Http;

namespace SAOCPSEDB.ClaimForm.Forms.Claim
{
    public abstract class AbstractForm
    {
        public AbstractForm()
        {
        }

        public List<ILogicValidator> Validators { get; set; } = new();

        public void Bind<TTable>(TTable table, SbcDbContext context) where TTable : class, new()
        {
            var tableType = typeof(TTable);
            var validatorType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.BaseType != null &&
                                     t.BaseType.IsGenericType &&
                                     t.BaseType.GetGenericTypeDefinition() == typeof(LogicValidator<>) &&
                                     t.BaseType.GenericTypeArguments[0] == tableType);

            if (validatorType == null)
                return;

            var logicValidator = (LogicValidator<TTable>)Activator.CreateInstance(validatorType, context, table);
            if (logicValidator == null)
                throw new InvalidOperationException("Logic Doesn't exist.");
            logicValidator.Update();
            Validators.Add(logicValidator);
        }
        public void Bind<TTable>(ICollection<TTable> tables, SbcDbContext context) where TTable : class, new()
        {
            foreach (var tTable in tables)
                Bind(tTable, context);
        }
        public void Update()
        {
            foreach (var logicValidator in Validators)
                logicValidator.Update(true);
        }
        public void Update(CallbackDto callback)
        {
            foreach (var logicValidator in Validators)
            {
                if (logicValidator.SetValue(callback.FieldName, callback.Value))
                    logicValidator.Update();
            }
        }
        public void Update(IFormCollection formData)
        {
            foreach (var key in formData.Keys)
            {
                foreach (var logicValidator in Validators)
                {
                    if (logicValidator.SetValue(key, formData[key]))
                        logicValidator.Update();
                }
            }
        }

        public void Update<TTable>(TTable table)
        {
            if (table == null)
                return;

            foreach (var logicValidator in Validators)
            {
                Type type = table.GetType();
                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    string propertyName = property.Name;
                    var propertyValue = property.GetValue(table);

                    if (logicValidator.SetValue(propertyName, propertyValue))
                        logicValidator.Update();
                }
            }
        }

        Dictionary<string, FormFieldAttributes> _cachedFormRules = null;
        public string ToJson()
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

            Dictionary<string, FormFieldAttributes> combinedFormRules = new Dictionary<string, FormFieldAttributes>();
            foreach (var logicValidator in Validators)
                logicValidator.FormRules.ToList().ForEach(x => combinedFormRules[x.Key] = new FormFieldAttributes(x.Value));

            _cachedFormRules = combinedFormRules; 

            var json = JsonConvert.SerializeObject(combinedFormRules, settings);
            return json;
        }

        public string GetJsonDelta(bool update = false)
        {
            if (_cachedFormRules == null)
                ToJson();

            if(update)
                Update();

            // Deserialize the cached JSON
            // var cachedFormRules = JsonConvert.DeserializeObject<Dictionary<string, FormFieldAttributes>>(_cachedJson);

            // Create a new dictionary to store the changes
            var deltaFormRules = new Dictionary<string, FormFieldAttributes>();

            // Get the current combined form rules
            Dictionary<string, FormFieldAttributes> combinedFormRules = new Dictionary<string, FormFieldAttributes>();
            foreach (var logicValidator in Validators)
                logicValidator.FormRules.ToList().ForEach(x => combinedFormRules[x.Key] = x.Value);

            // Compare the dictionaries and find changes
            foreach (var kvp in combinedFormRules)
            {
                var key = kvp.Key;
                if (_cachedFormRules.TryGetValue(key, out var cachedValue))
                {
                    if (!kvp.Value.Equals(cachedValue)) // Assumes FormFieldAttributes implements Equals method
                    {
                        var deltaAttributes = FormFieldAttributes.GetDeltaAttributes(cachedValue, kvp.Value);
                        if(deltaAttributes != null)
                            deltaFormRules[key] = deltaAttributes;
                    }
                }
                else
                {
                    // New key in the current dictionary
                    deltaFormRules[key] = kvp.Value;
                }
            }

            // Find keys that were in the cached dictionary but are not in the current dictionary (indicating removal)
            foreach (var kvp in _cachedFormRules)
            {
                var key = kvp.Key;
                if (!combinedFormRules.ContainsKey(key))
                {
                    deltaFormRules.Remove(key);
                }
            }

            // Serialize the delta dictionary to JSON
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
            };

            var deltaJson = JsonConvert.SerializeObject(deltaFormRules, settings);
            ToJson();
            return deltaJson;
        }

        public List<ValidationResult> Validate()
        {
            var errors = new List<ValidationResult>();
            foreach (var logicValidator in Validators)
            {
                var validationResult = logicValidator.Validate();
                errors.AddRange(validationResult);
            }

            return errors;
        }

        public void Save()
        {
            foreach (var logicValidator in Validators)
                logicValidator.Save();
        }

        public virtual async Task SaveAsync()
        {
            foreach (var logicValidator in Validators)
                await logicValidator.SaveAsync();
        }
    }
}
