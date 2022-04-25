using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anima.ProjetoIntegrador.Application.Services.Validators
{
    public static class ValidateErrors
    {
        public static List<string> ListErrors(List<string> ErrorList, ValidationResult validate)
        {
            foreach (var failure in validate.Errors)
            {
                ErrorList.Add($"Validate Error: {failure.PropertyName}, {failure.ErrorMessage}");
            }

            return ErrorList;
        }
    }
}
