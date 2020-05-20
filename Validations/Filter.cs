using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dc.Validations
{
    public class Filter : IValidatableObject
    {
        [Required(ErrorMessage = "From Date is Required.")]
        public DateTime From { get; set; } = DateTime.Today.Date;
        [Required(ErrorMessage = "To Date is Required.")]
        public DateTime To { get; set; } = DateTime.Today.Date.AddDays(1);
        public string Datacenter { get; set; }
        public bool ExportExcel { get; set; } = false;
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (From > To)
            {
                yield return
                  new ValidationResult(errorMessage: "\"From\" Date must be less than \"To\" Date",
                                       memberNames: new[] { "To" });
            }
        }
    }
}
