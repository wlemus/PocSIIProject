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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sii.cl/SiiDte")]
    [System.Xml.Serialization.XmlRootAttribute("DTE", Namespace = "http://www.sii.cl/SiiDte", IsNullable = false)]
    public partial class DTEDefType {

        private object itemField;

        private SignatureType signatureField;

        private decimal versionField;

        public DTEDefType() {
            this.versionField = ((decimal)(1.0m));
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Documento", typeof(DTEDefTypeDocumento))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
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
