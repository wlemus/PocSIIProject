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
    public partial class DTEDefTypeDocumento {

        private DTEDefTypeDocumentoEncabezado encabezadoField;

        private DTEDefTypeDocumentoDetalle[] detalleField;

        private DTEDefTypeDocumentoSubTotInfo[] subTotInfoField;

        private DTEDefTypeDocumentoDscRcgGlobal[] dscRcgGlobalField;

        private DTEDefTypeDocumentoReferencia[] referenciaField;

        private DTEDefTypeDocumentoGeoRefEmision geoRefEmisionField;

        private DTEDefTypeDocumentoManejoMadera manejoMaderaField;

        private DTEDefTypeDocumentoComisiones[] comisionesField;

        private DTEDefTypeDocumentoTED tEDField;

        private System.DateTime tmstFirmaField;

        private string idField;

        /// <remarks/>
        public DTEDefTypeDocumentoEncabezado Encabezado {
            get {
                return this.encabezadoField;
            }
            set {
                this.encabezadoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Detalle")]
        public DTEDefTypeDocumentoDetalle[] Detalle {
            get {
                return this.detalleField;
            }
            set {
                this.detalleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubTotInfo")]
        public DTEDefTypeDocumentoSubTotInfo[] SubTotInfo {
            get {
                return this.subTotInfoField;
            }
            set {
                this.subTotInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DscRcgGlobal")]
        public DTEDefTypeDocumentoDscRcgGlobal[] DscRcgGlobal {
            get {
                return this.dscRcgGlobalField;
            }
            set {
                this.dscRcgGlobalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Referencia")]
        public DTEDefTypeDocumentoReferencia[] Referencia {
            get {
                return this.referenciaField;
            }
            set {
                this.referenciaField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoGeoRefEmision GeoRefEmision {
            get {
                return this.geoRefEmisionField;
            }
            set {
                this.geoRefEmisionField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoManejoMadera ManejoMadera {
            get {
                return this.manejoMaderaField;
            }
            set {
                this.manejoMaderaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comisiones")]
        public DTEDefTypeDocumentoComisiones[] Comisiones {
            get {
                return this.comisionesField;
            }
            set {
                this.comisionesField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoTED TED {
            get {
                return this.tEDField;
            }
            set {
                this.tEDField = value;
            }
        }

        /// <remarks/>
        public System.DateTime TmstFirma {
            get {
                return this.tmstFirmaField;
            }
            set {
                this.tmstFirmaField = value;
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoSubTotInfo {

        private string nroSTIField;

        private string glosaSTIField;

        private string ordenSTIField;

        private decimal subTotNetoSTIField;

        private bool subTotNetoSTIFieldSpecified;

        private decimal subTotIVASTIField;

        private bool subTotIVASTIFieldSpecified;

        private decimal subTotAdicSTIField;

        private bool subTotAdicSTIFieldSpecified;

        private decimal subTotExeSTIField;

        private bool subTotExeSTIFieldSpecified;

        private decimal valSubtotSTIField;

        private bool valSubtotSTIFieldSpecified;

        private string[] lineasDetaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NroSTI {
            get {
                return this.nroSTIField;
            }
            set {
                this.nroSTIField = value;
            }
        }

        /// <remarks/>
        public string GlosaSTI {
            get {
                return this.glosaSTIField;
            }
            set {
                this.glosaSTIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string OrdenSTI {
            get {
                return this.ordenSTIField;
            }
            set {
                this.ordenSTIField = value;
            }
        }

        /// <remarks/>
        public decimal SubTotNetoSTI {
            get {
                return this.subTotNetoSTIField;
            }
            set {
                this.subTotNetoSTIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubTotNetoSTISpecified {
            get {
                return this.subTotNetoSTIFieldSpecified;
            }
            set {
                this.subTotNetoSTIFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SubTotIVASTI {
            get {
                return this.subTotIVASTIField;
            }
            set {
                this.subTotIVASTIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubTotIVASTISpecified {
            get {
                return this.subTotIVASTIFieldSpecified;
            }
            set {
                this.subTotIVASTIFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SubTotAdicSTI {
            get {
                return this.subTotAdicSTIField;
            }
            set {
                this.subTotAdicSTIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubTotAdicSTISpecified {
            get {
                return this.subTotAdicSTIFieldSpecified;
            }
            set {
                this.subTotAdicSTIFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal SubTotExeSTI {
            get {
                return this.subTotExeSTIField;
            }
            set {
                this.subTotExeSTIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubTotExeSTISpecified {
            get {
                return this.subTotExeSTIFieldSpecified;
            }
            set {
                this.subTotExeSTIFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal ValSubtotSTI {
            get {
                return this.valSubtotSTIField;
            }
            set {
                this.valSubtotSTIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValSubtotSTISpecified {
            get {
                return this.valSubtotSTIFieldSpecified;
            }
            set {
                this.valSubtotSTIFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LineasDeta", DataType = "positiveInteger")]
        public string[] LineasDeta {
            get {
                return this.lineasDetaField;
            }
            set {
                this.lineasDetaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoDscRcgGlobal {

        private string nroLinDRField;

        private DTEDefTypeDocumentoDscRcgGlobalTpoMov tpoMovField;

        private string glosaDRField;

        private DineroPorcentajeType tpoValorField;

        private decimal valorDRField;

        private decimal valorDROtrMndaField;

        private bool valorDROtrMndaFieldSpecified;

        private DTEDefTypeDocumentoDscRcgGlobalIndExeDR indExeDRField;

        private bool indExeDRFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NroLinDR {
            get {
                return this.nroLinDRField;
            }
            set {
                this.nroLinDRField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoDscRcgGlobalTpoMov TpoMov {
            get {
                return this.tpoMovField;
            }
            set {
                this.tpoMovField = value;
            }
        }

        /// <remarks/>
        public string GlosaDR {
            get {
                return this.glosaDRField;
            }
            set {
                this.glosaDRField = value;
            }
        }

        /// <remarks/>
        public DineroPorcentajeType TpoValor {
            get {
                return this.tpoValorField;
            }
            set {
                this.tpoValorField = value;
            }
        }

        /// <remarks/>
        public decimal ValorDR {
            get {
                return this.valorDRField;
            }
            set {
                this.valorDRField = value;
            }
        }

        /// <remarks/>
        public decimal ValorDROtrMnda {
            get {
                return this.valorDROtrMndaField;
            }
            set {
                this.valorDROtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValorDROtrMndaSpecified {
            get {
                return this.valorDROtrMndaFieldSpecified;
            }
            set {
                this.valorDROtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoDscRcgGlobalIndExeDR IndExeDR {
            get {
                return this.indExeDRField;
            }
            set {
                this.indExeDRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndExeDRSpecified {
            get {
                return this.indExeDRFieldSpecified;
            }
            set {
                this.indExeDRFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoDscRcgGlobalTpoMov {

        /// <remarks/>
        D,

        /// <remarks/>
        R,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoDscRcgGlobalIndExeDR {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoReferencia {

        private string nroLinRefField;

        private string tpoDocRefField;

        private DTEDefTypeDocumentoReferenciaIndGlobal indGlobalField;

        private bool indGlobalFieldSpecified;

        private string folioRefField;

        private string rUTOtrField;

        private System.DateTime fchRefField;

        private DTEDefTypeDocumentoReferenciaCodRef codRefField;

        private bool codRefFieldSpecified;

        private string razonRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NroLinRef {
            get {
                return this.nroLinRefField;
            }
            set {
                this.nroLinRefField = value;
            }
        }

        /// <remarks/>
        public string TpoDocRef {
            get {
                return this.tpoDocRefField;
            }
            set {
                this.tpoDocRefField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoReferenciaIndGlobal IndGlobal {
            get {
                return this.indGlobalField;
            }
            set {
                this.indGlobalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndGlobalSpecified {
            get {
                return this.indGlobalFieldSpecified;
            }
            set {
                this.indGlobalFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string FolioRef {
            get {
                return this.folioRefField;
            }
            set {
                this.folioRefField = value;
            }
        }

        /// <remarks/>
        public string RUTOtr {
            get {
                return this.rUTOtrField;
            }
            set {
                this.rUTOtrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchRef {
            get {
                return this.fchRefField;
            }
            set {
                this.fchRefField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoReferenciaCodRef CodRef {
            get {
                return this.codRefField;
            }
            set {
                this.codRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CodRefSpecified {
            get {
                return this.codRefFieldSpecified;
            }
            set {
                this.codRefFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string RazonRef {
            get {
                return this.razonRefField;
            }
            set {
                this.razonRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoReferenciaIndGlobal {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoReferenciaCodRef {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoGeoRefEmision {

        private string latitudEmisionField;

        private string longitudEmisionField;

        private string sistemaReferenciaField;

        /// <remarks/>
        public string LatitudEmision {
            get {
                return this.latitudEmisionField;
            }
            set {
                this.latitudEmisionField = value;
            }
        }

        /// <remarks/>
        public string LongitudEmision {
            get {
                return this.longitudEmisionField;
            }
            set {
                this.longitudEmisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string SistemaReferencia {
            get {
                return this.sistemaReferenciaField;
            }
            set {
                this.sistemaReferenciaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoManejoMadera {

        private string comunaRolOrigenField;

        private string mnzRolOrigenField;

        private string prdRolOrigenField;

        private string codPlanConafField;

        private string latitudOrigenMaderaField;

        private string longitudOrigenMaderaField;

        private string sistemareferenciaMaderaField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string ComunaRolOrigen {
            get {
                return this.comunaRolOrigenField;
            }
            set {
                this.comunaRolOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string MnzRolOrigen {
            get {
                return this.mnzRolOrigenField;
            }
            set {
                this.mnzRolOrigenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string PrdRolOrigen {
            get {
                return this.prdRolOrigenField;
            }
            set {
                this.prdRolOrigenField = value;
            }
        }

        /// <remarks/>
        public string CodPlanConaf {
            get {
                return this.codPlanConafField;
            }
            set {
                this.codPlanConafField = value;
            }
        }

        /// <remarks/>
        public string LatitudOrigenMadera {
            get {
                return this.latitudOrigenMaderaField;
            }
            set {
                this.latitudOrigenMaderaField = value;
            }
        }

        /// <remarks/>
        public string LongitudOrigenMadera {
            get {
                return this.longitudOrigenMaderaField;
            }
            set {
                this.longitudOrigenMaderaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string SistemareferenciaMadera {
            get {
                return this.sistemareferenciaMaderaField;
            }
            set {
                this.sistemareferenciaMaderaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoComisiones {

        private string nroLinComField;

        private DTEDefTypeDocumentoComisionesTipoMovim tipoMovimField;

        private string glosaField;

        private decimal tasaComisionField;

        private bool tasaComisionFieldSpecified;

        private string valComNetoField;

        private string valComExeField;

        private string valComIVAField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NroLinCom {
            get {
                return this.nroLinComField;
            }
            set {
                this.nroLinComField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoComisionesTipoMovim TipoMovim {
            get {
                return this.tipoMovimField;
            }
            set {
                this.tipoMovimField = value;
            }
        }

        /// <remarks/>
        public string Glosa {
            get {
                return this.glosaField;
            }
            set {
                this.glosaField = value;
            }
        }

        /// <remarks/>
        public decimal TasaComision {
            get {
                return this.tasaComisionField;
            }
            set {
                this.tasaComisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TasaComisionSpecified {
            get {
                return this.tasaComisionFieldSpecified;
            }
            set {
                this.tasaComisionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string ValComNeto {
            get {
                return this.valComNetoField;
            }
            set {
                this.valComNetoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string ValComExe {
            get {
                return this.valComExeField;
            }
            set {
                this.valComExeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string ValComIVA {
            get {
                return this.valComIVAField;
            }
            set {
                this.valComIVAField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoComisionesTipoMovim {

        /// <remarks/>
        C,

        /// <remarks/>
        O,
    }
}
