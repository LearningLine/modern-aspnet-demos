using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ValidationDemo2.Models
{
    public class Employee// : IValidatableObject
    {
        public string Id { get; set; }
        [MinLength(10, ErrorMessage = "We need your name")]
        public string Password { get; set; }
        [Required(ErrorMessage = "We need your name")]
        public string Name { get; set; }
        [Range(18, 120)]
        public int Age { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Age < 18)
            {
                yield return new ValidationResult("You need to be more than 18",
                    new[] {nameof(Age)});
            }
            if (string.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("You need a name",
                    new[] {nameof(Name)});
            }
        }
    }
}

