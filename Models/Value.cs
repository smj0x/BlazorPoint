using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dc.Models
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
        public AttachmentUrl AttachmentUrl { get; set; }
        public string GUID { get; set; }
        public string Status { get; set; }
        public string Purpose { get; set; }
        //Tasks
        public string Body { get; set; }
        public string Priority { get; set; }
        public string ApproverComments { get; set; }
        public TaskGroup TaskGroup { get; set; }
        public AssignedTo AssignedTo { get; set; }
        public string WorkflowOutcome { get; set; }
        //Site Groups
        public string LoginName { get; set; }
        public string OwnerTitle { get; set; }
        public string Description { get; set; }
        //Visitor
        public Employee Employee { get; set; }
        public string PoV { get; set; }
        public string IdentityNumber { get; set; }
        public string NationalID { get; set; }
        public string FullName { get; set; }
        public string ContactNumber { get; set; }
        public string WorkEmail { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Datacenter { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string VisitorType { get; set; }
    }

    public class AttachmentFiles
    {
        public string FileName { get; set; }
        public string ServerRelativeUrl { get; set; }
    }  
    
    public class AttachmentUrl
    {
        public string Description { get; set; }
        public string Url { get; set; }
    }

    public class Employee
    {
        public string Title { get; set; }
        public string EMail { get; set; }
        public string UserName { get; set; }
        public string WorkPhone { get; set; }
        public string Office { get; set; }
        public string Department { get; set; }
    }
    public class AssignedTo
    {
        public string Title { get; set; }
    }

    public class TaskGroup
    {
        public string Title { get; set; }
    }
}