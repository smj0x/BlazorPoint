using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lms.Validaitions
{
    public class LicenseValidation
    {
        [Required]
        public string SystemName { get; set; }
        [Required]
        public string LicenseName { get; set; }
        [Required]
        public string LicenseKey { get; set; }
        [Required]
        public string ContractNumber { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Today.Date;
        [Required]
        public DateTime EndDate { get; set; } = DateTime.Today.Date;
        [Required]
        public DateTime IssuedDate { get; set; } = DateTime.Today.Date;
        [Required]
        public DateTime PlannedRenewal { get; set; } = DateTime.Today.Date;
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Utilized { get; set; }
        [Required]
        public int Cost { get; set; }
        [Required]
        public int TotalCost { get; set; }
        [Required]
        public string TypeOfCost { get; set; }
    }
}
