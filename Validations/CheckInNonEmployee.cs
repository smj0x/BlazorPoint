using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dc.Validations
{
    public class CheckInNonEmployee
    {
        [Required(ErrorMessage = "Purpose of Visit field is required.")]
        public string PoV { get; set; }
        [Required(ErrorMessage = "National ID field is required.")]
        public string NationalID { get; set; }
        [Required(ErrorMessage = "Name field is required.")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Contact Number field is required.")]
        [Phone]
        public string ContactNumber { get; set; }
        //[Required(ErrorMessage = "Work Email field is required.")]
        [EmailAddress]
        public string WorkEmail { get; set; }
        [Required]
        public string Company { get; set; }
        public string Datacenter { get; set; }
        public DateTime CheckIn { get; set; }
        public string VisitorType { get; set; }
        public string AttachmentURL { get; set; }
    }
}
