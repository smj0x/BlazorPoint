using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lms.Models
{
    public class Value
    {
        //Default
        public int FileSystemObjectType { get; set; }
        public int Id { get; set; }
        public int ID { get; set; }
        public string Title { get; set; }
        public string ContentTypeId { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public int AuthorId { get; set; }
        public int EditorId { get; set; }
        public string OData__UIVersionString { get; set; }
        public bool Attachments { get; set; }
        public List<AttachmentFiles> AttachmentFiles { get; set; }
        public string GUID { get; set; }
        //Tasks
        [JsonProperty("Body")]
        public string Body { get; set; }
        [JsonProperty("Priority")]
        public string Priority { get; set; }
        [JsonProperty("Status")]
        public string Status { get; set; }

        //Licenses
        public string SystemName { get; set; }
        public string LicenseName { get; set; }
        public string LicenseKey { get; set; }
        public Owner Owner { get; set; }
        public int OwnerId { get; set; }
        public string ContractNumber { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime PlannedRenewal { get; set; }
        public double Quantity { get; set; }
        public double Utilized { get; set; }
        public double Cost { get; set; }
        public double TotalCost { get; set; }
        public string TypeOfCost { get; set; }
    }

    public class AttachmentFiles
    {
        public string FileName { get; set; }
        public string ServerRelativeUrl { get; set; }
    }

    public class Owner
    {
        public string Title { get; set; }
        public string EMail { get; set; }
        public string UserName { get; set; }
        public string WorkPhone { get; set; }
        public string Office { get; set; }
        public string Department { get; set; }
    }

}