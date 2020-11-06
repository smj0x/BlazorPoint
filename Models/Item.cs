using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dc.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Item
    {
        //General
        [JsonProperty("__metadata")]
        public Metadata Metadata { get; set; }
        public string Title { get; set; }
        //Visitor
        public int? EmployeeId { get; set; }
        public string PoV { get; set; }
        public string IdentityNumber { get; set; }
        public string NationalID { get; set; }
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
        public string WorkEmail { get; set; }
        public string Company { get; set; }
        public string Datacenter { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string VisitorType { get; set; }
        public string Status { get; set; }
        public string Purpose { get; set; }
        public AttachmentUrl AttachmentUrl { get; set; }
    }
}
