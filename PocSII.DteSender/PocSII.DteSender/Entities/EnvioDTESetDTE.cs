using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteProcessor.Entities
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class EnvioDTESetDTE {

        private EnvioDTESetDTECaratula caratulaField;

        private DTEDefType[] dTEField;

        private string idField;

        /// <remarks/>
        public EnvioDTESetDTECaratula Caratula {
            get {
                return this.caratulaField;
            }
            set {
                this.caratulaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DTE")]
        public DTEDefType[] DTE {
            get {
                return this.dTEField;
            }
            set {
                this.dTEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}
