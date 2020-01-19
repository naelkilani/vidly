using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Vidly.Dtos;
using Vidly.Utilities;

namespace Vidly.Validation
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customerDto = (CustomerDto)validationContext.ObjectInstance;

            if (customerDto.MembershipId == CustomerDto.Unkown ||
                customerDto.MembershipId == CustomerDto.PayAsYouGo)
                return ValidationResult.Success;

            if (customerDto.Birthdate == null)
                return new ValidationResult($"{GetDisplayName()} is required.");

            var age = customerDto.Birthdate.Value.CalculateAge();

            return age < 18
                ? new ValidationResult("Customer should be at least 18 to go with membership.")
                : ValidationResult.Success;
        }

        private string GetDisplayName()
        {
            const string defaultValidationMsg = "Birthdate field";
            try
            {
                var property = typeof(CustomerDto).GetProperty("Birthdate");
                if (property == null)
                    return defaultValidationMsg;

                var attribute = (DisplayAttribute)property.GetCustomAttributes(typeof(DisplayAttribute), true).FirstOrDefault();

                return attribute == null ? defaultValidationMsg : attribute.Name;
            }
            catch (Exception)
            {
                return defaultValidationMsg;
            }
        }
    }
}