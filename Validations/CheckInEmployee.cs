using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dc.Validations
{
    public class CheckInEmployee
    {
        [Required(ErrorMessage = "Purpose of Visit field is required.")]
        public string PoV { get; set; }
        public string Datacenter { get; set; }
        public DateTime CheckIn { get; set; }
        public string VisitorType { get; set; }
    }
}
