using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Models
{
    public class Upload
    {
        public string controlId { get; set; }
        public string url { get; set; }
        public string listGuidMain { get; set; }
        public int itemId { get; set; }
        public string digest { get; set; }
    }
}
