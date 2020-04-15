using System.ComponentModel.DataAnnotations;

namespace WebCoreApp.Services.Infrastructure.Validators
{
    public class ValidDepartmentNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            string sValue = value.ToString();

            if (string.IsNullOrEmpty(sValue))
                return false;

            if (sValue.StartsWith("D"))
                return true;

            return false;
        }
    }
}
