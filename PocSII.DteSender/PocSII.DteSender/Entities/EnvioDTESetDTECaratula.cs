using PocSII.DteBusinessRules.Enums;
using PocSII.DteProcessor.Enums;
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
    public partial class EnvioDTESetDTECaratula {

        private string rutEmisorField;

        private string rutEnviaField;

        private string rutReceptorField;

        private System.DateTime fchResolField;

        private string nroResolField;

        private System.DateTime tmstFirmaEnvField;

        private EnvioDTESetDTECaratulaSubTotDTE[] subTotDTEField;

        private decimal versionField;

        public EnvioDTESetDTECaratula() {
            this.versionField = ((decimal)(1.0m));
        }

        /// <remarks/>
        public string RutEmisor {
            get {
                return this.rutEmisorField;
            }
            set {
                this.rutEmisorField = value;
            }
        }

        /// <remarks/>
        public string RutEnvia {
            get {
                return this.rutEnviaField;
            }
            set {
                this.rutEnviaField = value;
            }
        }

        /// <remarks/>
        public string RutReceptor {
            get {
                return this.rutReceptorField;
            }
            set {
                this.rutReceptorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchResol {
            get {
                return this.fchResolField;
            }
            set {
                this.fchResolField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string NroResol {
            get {
                return this.nroResolField;
            }
            set {
                this.nroResolField = value;
            }
        }

        /// <remarks/>
        public System.DateTime TmstFirmaEnv {
            get {
                return this.tmstFirmaEnvField;
            }
            set {
                this.tmstFirmaEnvField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubTotDTE")]
        public EnvioDTESetDTECaratulaSubTotDTE[] SubTotDTE {
            get {
                return this.subTotDTEField;
            }
            set {
                this.subTotDTEField = value;
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


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class EnvioDTESetDTECaratulaSubTotDTE {

        private DOCType tpoDTEField;

        private string nroDTEField;

        /// <remarks/>
        public DOCType TpoDTE {
            get {
                return this.tpoDTEField;
            }
            set {
                this.tpoDTEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NroDTE {
            get {
                return this.nroDTEField;
            }
            set {
                this.nroDTEField = value;
            }
        }
    }
}

