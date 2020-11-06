using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace dc.Models
{
    [XmlRoot(ElementName = "ConfiguredOutcome", Namespace = "http://nintex.com")]
    public class ConfiguredOutcome
    {
        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "CommentsMode")]
        public string CommentsMode { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
        [XmlAttribute(AttributeName = "BranchIndex")]
        public string BranchIndex { get; set; }
    }

    [XmlRoot(ElementName = "GetOutcomesForFlexiTaskResult", Namespace = "http://nintex.com")]
    public class GetOutcomesForFlexiTaskResult
    {
        [XmlElement(ElementName = "ConfiguredOutcome", Namespace = "http://nintex.com")]
        public List<ConfiguredOutcome> ConfiguredOutcome { get; set; }
    }

    [XmlRoot(ElementName = "GetOutcomesForFlexiTaskResponse", Namespace = "http://nintex.com")]
    public class GetOutcomesForFlexiTaskResponse
    {
        [XmlElement(ElementName = "GetOutcomesForFlexiTaskResult", Namespace = "http://nintex.com")]
        public GetOutcomesForFlexiTaskResult GetOutcomesForFlexiTaskResult { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Body
    {
        [XmlElement(ElementName = "GetOutcomesForFlexiTaskResponse", Namespace = "http://nintex.com")]
        public GetOutcomesForFlexiTaskResponse GetOutcomesForFlexiTaskResponse { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public class Envelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soap { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
    }

}
