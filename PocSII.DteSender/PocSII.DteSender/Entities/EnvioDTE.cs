using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocSII.DteProcessor.Entities {
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    [System.Xml.Serialization.XmlRootAttribute(  Namespace = "http://www.sii.cl/SiiDte", IsNullable = false)]
    public partial class EnvioDTE {

        private EnvioDTESetDTE setDTEField;

        private SignatureType signatureField;

        private decimal versionField;

        public EnvioDTE() {
            this.versionField = ((decimal)(1.0m));
        }

        /// <remarks/>
        public EnvioDTESetDTE SetDTE {
            get {
                return this.setDTEField;
            }
            set {
                this.setDTEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
}
