using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace PocSII.DteBusinessRules.Domain {

        [XmlRoot(ElementName = "RESPUESTA")]
        public class DTEResponseQuery {
            [XmlElement(ElementName = "RESP_HDR")]
            public RespuestaHeader Header { get; set; }
        }

        public class RespuestaHeader {
            [XmlElement(ElementName = "ESTADO")]
            public string Estado { get; set; }

            [XmlElement(ElementName = "GLOSA")]
            public string Glosa { get; set; }

            [XmlElement(ElementName = "ERR_CODE")]
            public int? CodigoError { get; set; }

            [XmlElement(ElementName = "GLOSA_ERR")]
            public string GlosaError { get; set; }

            [XmlElement(ElementName = "NUM_ATENCION")]
            public string NumeroAtencion { get; set; }
        }
    }

