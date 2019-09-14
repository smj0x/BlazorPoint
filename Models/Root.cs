using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Models
{
    public class Root
    {        
        public List<Value> value { get; set; }
        public string Title { get; set; }
        public string LoginName { get; set; }
        public int Id { get; set; }
        public string FormDigestValue { get; set; }
        [JsonProperty("odata.nextLink")]
        public string OdataNextLink { get; set; }
    }
}
