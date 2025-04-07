using PocSII.DteProcessor.Enums;
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
    public partial class DTEDefTypeDocumentoDetalle {

        private string nroLinDetField;

        private DTEDefTypeDocumentoDetalleCdgItem[] cdgItemField;

        private DTEDefTypeDocumentoDetalleIndExe indExeField;

        private bool indExeFieldSpecified;

        private DTEDefTypeDocumentoDetalleRetenedor retenedorField;

        private string nmbItemField;

        private string dscItemField;

        private decimal qtyRefField;

        private bool qtyRefFieldSpecified;

        private string unmdRefField;

        private decimal prcRefField;

        private bool prcRefFieldSpecified;

        private decimal qtyItemField;

        private bool qtyItemFieldSpecified;

        private DTEDefTypeDocumentoDetalleSubcantidad[] subcantidadField;

        private System.DateTime fchElaborField;

        private bool fchElaborFieldSpecified;

        private System.DateTime fchVencimField;

        private bool fchVencimFieldSpecified;

        private string unmdItemField;

        private decimal prcItemField;

        private bool prcItemFieldSpecified;

        private DTEDefTypeDocumentoDetalleOtrMnda otrMndaField;

        private decimal descuentoPctField;

        private bool descuentoPctFieldSpecified;

        private string descuentoMontoField;

        private DTEDefTypeDocumentoDetalleSubDscto[] subDsctoField;

        private decimal recargoPctField;

        private bool recargoPctFieldSpecified;

        private string recargoMontoField;

        private DTEDefTypeDocumentoDetalleSubRecargo[] subRecargoField;

        private ImpAdicDTEType[] codImpAdicField;

        private string montoItemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string NroLinDet {
            get {
                return this.nroLinDetField;
            }
            set {
                this.nroLinDetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CdgItem")]
        public DTEDefTypeDocumentoDetalleCdgItem[] CdgItem {
            get {
                return this.cdgItemField;
            }
            set {
                this.cdgItemField = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoDetalleIndExe IndExe {
            get {
                return this.indExeField;
            }
            set {
                this.indExeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IndExeSpecified {
            get {
                return this.indExeFieldSpecified;
            }
            set {
                this.indExeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoDetalleRetenedor Retenedor {
            get {
                return this.retenedorField;
            }
            set {
                this.retenedorField = value;
            }
        }

        /// <remarks/>
        public string NmbItem {
            get {
                return this.nmbItemField;
            }
            set {
                this.nmbItemField = value;
            }
        }

        /// <remarks/>
        public string DscItem {
            get {
                return this.dscItemField;
            }
            set {
                this.dscItemField = value;
            }
        }

        /// <remarks/>
        public decimal QtyRef {
            get {
                return this.qtyRefField;
            }
            set {
                this.qtyRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtyRefSpecified {
            get {
                return this.qtyRefFieldSpecified;
            }
            set {
                this.qtyRefFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string UnmdRef {
            get {
                return this.unmdRefField;
            }
            set {
                this.unmdRefField = value;
            }
        }

        /// <remarks/>
        public decimal PrcRef {
            get {
                return this.prcRefField;
            }
            set {
                this.prcRefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrcRefSpecified {
            get {
                return this.prcRefFieldSpecified;
            }
            set {
                this.prcRefFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal QtyItem {
            get {
                return this.qtyItemField;
            }
            set {
                this.qtyItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QtyItemSpecified {
            get {
                return this.qtyItemFieldSpecified;
            }
            set {
                this.qtyItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subcantidad")]
        public DTEDefTypeDocumentoDetalleSubcantidad[] Subcantidad {
            get {
                return this.subcantidadField;
            }
            set {
                this.subcantidadField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchElabor {
            get {
                return this.fchElaborField;
            }
            set {
                this.fchElaborField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FchElaborSpecified {
            get {
                return this.fchElaborFieldSpecified;
            }
            set {
                this.fchElaborFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime FchVencim {
            get {
                return this.fchVencimField;
            }
            set {
                this.fchVencimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FchVencimSpecified {
            get {
                return this.fchVencimFieldSpecified;
            }
            set {
                this.fchVencimFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string UnmdItem {
            get {
                return this.unmdItemField;
            }
            set {
                this.unmdItemField = value;
            }
        }

        /// <remarks/>
        public decimal PrcItem {
            get {
                return this.prcItemField;
            }
            set {
                this.prcItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrcItemSpecified {
            get {
                return this.prcItemFieldSpecified;
            }
            set {
                this.prcItemFieldSpecified = value;
            }
        }

        /// <remarks/>
        public DTEDefTypeDocumentoDetalleOtrMnda OtrMnda {
            get {
                return this.otrMndaField;
            }
            set {
                this.otrMndaField = value;
            }
        }

        /// <remarks/>
        public decimal DescuentoPct {
            get {
                return this.descuentoPctField;
            }
            set {
                this.descuentoPctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DescuentoPctSpecified {
            get {
                return this.descuentoPctFieldSpecified;
            }
            set {
                this.descuentoPctFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string DescuentoMonto {
            get {
                return this.descuentoMontoField;
            }
            set {
                this.descuentoMontoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubDscto")]
        public DTEDefTypeDocumentoDetalleSubDscto[] SubDscto {
            get {
                return this.subDsctoField;
            }
            set {
                this.subDsctoField = value;
            }
        }

        /// <remarks/>
        public decimal RecargoPct {
            get {
                return this.recargoPctField;
            }
            set {
                this.recargoPctField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecargoPctSpecified {
            get {
                return this.recargoPctFieldSpecified;
            }
            set {
                this.recargoPctFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "positiveInteger")]
        public string RecargoMonto {
            get {
                return this.recargoMontoField;
            }
            set {
                this.recargoMontoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubRecargo")]
        public DTEDefTypeDocumentoDetalleSubRecargo[] SubRecargo {
            get {
                return this.subRecargoField;
            }
            set {
                this.subRecargoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CodImpAdic")]
        public ImpAdicDTEType[] CodImpAdic {
            get {
                return this.codImpAdicField;
            }
            set {
                this.codImpAdicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MontoItem {
            get {
                return this.montoItemField;
            }
            set {
                this.montoItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoDetalleCdgItem {

        private string tpoCodigoField;

        private string vlrCodigoField;

        /// <remarks/>
        public string TpoCodigo {
            get {
                return this.tpoCodigoField;
            }
            set {
                this.tpoCodigoField = value;
            }
        }

        /// <remarks/>
        public string VlrCodigo {
            get {
                return this.vlrCodigoField;
            }
            set {
                this.vlrCodigoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoDetalleIndExe {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoDetalleRetenedor {

        private DTEDefTypeDocumentoDetalleRetenedorIndAgente indAgenteField;

        private string mntBaseFaenaField;

        private string mntMargComerField;

        private string prcConsFinalField;

        /// <remarks/>
        public DTEDefTypeDocumentoDetalleRetenedorIndAgente IndAgente {
            get {
                return this.indAgenteField;
            }
            set {
                this.indAgenteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntBaseFaena {
            get {
                return this.mntBaseFaenaField;
            }
            set {
                this.mntBaseFaenaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string MntMargComer {
            get {
                return this.mntMargComerField;
            }
            set {
                this.mntMargComerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string PrcConsFinal {
            get {
                return this.prcConsFinalField;
            }
            set {
                this.prcConsFinalField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public enum DTEDefTypeDocumentoDetalleRetenedorIndAgente {

        /// <remarks/>
        R,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoDetalleSubcantidad {

        private decimal subQtyField;

        private string subCodField;

        /// <remarks/>
        public decimal SubQty {
            get {
                return this.subQtyField;
            }
            set {
                this.subQtyField = value;
            }
        }

        /// <remarks/>
        public string SubCod {
            get {
                return this.subCodField;
            }
            set {
                this.subCodField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoDetalleOtrMnda {

        private decimal prcOtrMonField;

        private string monedaField;

        private decimal fctConvField;

        private bool fctConvFieldSpecified;

        private decimal dctoOtrMndaField;

        private bool dctoOtrMndaFieldSpecified;

        private decimal recargoOtrMndaField;

        private bool recargoOtrMndaFieldSpecified;

        private decimal montoItemOtrMndaField;

        private bool montoItemOtrMndaFieldSpecified;

        /// <remarks/>
        public decimal PrcOtrMon {
            get {
                return this.prcOtrMonField;
            }
            set {
                this.prcOtrMonField = value;
            }
        }

        /// <remarks/>
        public string Moneda {
            get {
                return this.monedaField;
            }
            set {
                this.monedaField = value;
            }
        }

        /// <remarks/>
        public decimal FctConv {
            get {
                return this.fctConvField;
            }
            set {
                this.fctConvField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FctConvSpecified {
            get {
                return this.fctConvFieldSpecified;
            }
            set {
                this.fctConvFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal DctoOtrMnda {
            get {
                return this.dctoOtrMndaField;
            }
            set {
                this.dctoOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DctoOtrMndaSpecified {
            get {
                return this.dctoOtrMndaFieldSpecified;
            }
            set {
                this.dctoOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal RecargoOtrMnda {
            get {
                return this.recargoOtrMndaField;
            }
            set {
                this.recargoOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecargoOtrMndaSpecified {
            get {
                return this.recargoOtrMndaFieldSpecified;
            }
            set {
                this.recargoOtrMndaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public decimal MontoItemOtrMnda {
            get {
                return this.montoItemOtrMndaField;
            }
            set {
                this.montoItemOtrMndaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MontoItemOtrMndaSpecified {
            get {
                return this.montoItemOtrMndaFieldSpecified;
            }
            set {
                this.montoItemOtrMndaFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoDetalleSubDscto {

        private DineroPorcentajeType tipoDsctoField;

        private decimal valorDsctoField;

        /// <remarks/>
        public DineroPorcentajeType TipoDscto {
            get {
                return this.tipoDsctoField;
            }
            set {
                this.tipoDsctoField = value;
            }
        }

        /// <remarks/>
        public decimal ValorDscto {
            get {
                return this.valorDsctoField;
            }
            set {
                this.valorDsctoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.sii.cl/SiiDte")]
    public enum DineroPorcentajeType {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("%")]
        Item,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("$")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.sii.cl/SiiDte")]
    public partial class DTEDefTypeDocumentoDetalleSubRecargo {

        private DineroPorcentajeType tipoRecargoField;

        private decimal valorRecargoField;

        /// <remarks/>
        public DineroPorcentajeType TipoRecargo {
            get {
                return this.tipoRecargoField;
            }
            set {
                this.tipoRecargoField = value;
            }
        }

        /// <remarks/>
        public decimal ValorRecargo {
            get {
                return this.valorRecargoField;
            }
            set {
                this.valorRecargoField = value;
            }
        }
    }


}
