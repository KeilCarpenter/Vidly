using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipAgeRestriction : ValidationAttribute
    {
        // Implements custom validation
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Get access to customer class
            var customer = (Customer) validationContext.ObjectInstance;

            /* Check if customer has a 'Pay As You Go' membership type
               No magic number used or maintainability (set in model)*/
            if (customer.MembershipTypeId == MembershipType.Unknown  || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo)           
                return ValidationResult.Success;
            
            // If there is no DOB
            if (customer.Birthdate == null)         
                return new ValidationResult("Birthdate is required");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            /* If customer is over 18 then validation is successful
             * If not then validation is not successful */
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer must be atleast 18 years old to go on a membership");
        }
    }
}
 