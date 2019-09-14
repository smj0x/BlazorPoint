using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace lms.Models
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Item
    {
        //General
        [JsonProperty("__metadata")]
        public Metadata Metadata { get; set; }
        public string Title { get; set; }
        //Licenses
        public string SystemName { get; set; }
        public string LicenseName { get; set; }
        public string LicenseKey { get; set; }
        public int? OwnerId { get; set; }
        public string ContractNumber { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? IssuedDate { get; set; }
        public DateTime? PlannedRenewal { get; set; }
        public double? Quantity { get; set; }
        public double? Utilized { get; set; }
        public double? Cost { get; set; }
        public double? TotalCost { get; set; }
        public string TypeOfCost { get; set; }
    }
}
