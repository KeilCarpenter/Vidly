using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieStockValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Get access to customer class
            var movie = (Movie) validationContext.ObjectInstance;

            /* If movie stock is with range validate success
             * If not then validation is not successful */
            return (movie.NumberInStock > Movie.NoStock && movie.NumberInStock <= Movie.MaxStock)
                ? ValidationResult.Success
                : new ValidationResult("Stock must be between 0 and 21");
        }
    }
}