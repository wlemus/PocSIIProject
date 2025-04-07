using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace PocSII.DteBusinessRules.Domain {
    [XmlRoot("RECEPCIONDTE")]
    public class DTEResponseReception {
        [XmlElement("RUTSENDER")]
        public string RutSender { get; set; }

        [XmlElement("RUTCOMPANY")]
        public string RutCompany { get; set; }

        [XmlElement("FILE")]
        public string File { get; set; }

        [XmlElement("TIMESTAMP")]
        public string Timestamp { get; set; }

        [XmlElement("STATUS")]
        public int Status { get; set; }

        [XmlElement("TRACKID")]
        public int TrackId { get; set; }

        [XmlArray("DETAIL")]
        [XmlArrayItem("ERROR")]
        public List<string> Errors { get; set; }

    }
}
