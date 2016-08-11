using System.ComponentModel.DataAnnotations;

namespace Core.Services
{
    public class DoubleValidationAttribute:ValidationAttribute
    {
            public override bool IsValid(object value)
            {
                return value is double;
            }
    }
}
