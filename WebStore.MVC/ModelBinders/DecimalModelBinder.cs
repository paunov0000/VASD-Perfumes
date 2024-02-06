using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Metadata;
using System.Globalization;
using static WebStore.Core.Constants.ErrorMessageConstants.General;

namespace WebStore.MVC.ModelBinders
{
    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueProviderResult != ValueProviderResult.None && !string.IsNullOrEmpty(valueProviderResult.FirstValue))
            {
                decimal value = 0M;

                bool success = false;

                try
                {
                    var decValue = valueProviderResult.FirstValue;

                    decValue = decValue.Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                    decValue = decValue.Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);

                    value = Convert.ToDecimal(decValue, CultureInfo.InvariantCulture);
                    success = true;
                }
                catch (FormatException fe)
                {
                    var displayName = bindingContext.ModelMetadata.GetDisplayName();

                    bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, string.Format(InvalidFieldMessage, displayName));
                }

                if (success)
                {
                    bindingContext.Result = ModelBindingResult.Success(value);
                }
            }

            return Task.CompletedTask;
        }
    }
}
